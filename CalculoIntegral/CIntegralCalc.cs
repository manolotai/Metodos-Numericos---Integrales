using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBackPack;
using Jace;     //Herramienta para analizar strings
using MisGrafos;
using System.Diagnostics;
using System.Threading;

namespace CalculoIntegral {
    using Result = CResult.TimeCount<CIntegralCalc.RGeneric>;
    using ParamFunc = JaceFunciones.R2;
    using ParamError = CErrorCalc.ParamsError;
    using Point = JaceFunciones.Point;
    class CIntegralCalc {
        public struct RGeneric {
            public double? Valor;
            public List<Point> Exitos;
            public List<Point> Fallos;

            public RGeneric(double? valor, List<Point> exitos, List<Point> fallos)
            {
                Valor = valor;
                Exitos = exitos;
                Fallos = fallos;
            }
        }
            

        public static Result Riemann(ParamFunc funcion, ParamError error)
        {
            Stopwatch time = new Stopwatch();
            var delMenorTolerancia = CErrorCalc.IsAceptable(error.Confianza);
            var delFunc = JaceFunciones.Fx(funcion.Funcion, funcion.Parametro);
            bool ciclo;
            int n = (int)funcion.Incremento;
            double a = funcion.A, b = funcion.B, vActual = 0, vAnterior = 0, vReal = 0, deltaX;

            if (error.Verdadero)
                vReal = TeoremaCalculo(funcion);

            time.Start();
            do {
                vAnterior = vActual;                                            // En caso de que el calcul osea sin el TF se traspasa el valor actual al anterior
                vActual = 0;
                deltaX = (b - a) / n;

                for (double i = a; i < b; i += deltaX) {                        //Sumatoria de la funcion
                    vActual += delFunc(i);
                }

                vActual *= deltaX;                                              //El valor de la sumatoria se multiplica por deltaX

                n += (int)funcion.Incremento;
                if (error.TokenCancel.IsCancellationRequested)
                    return new Result(new RGeneric(null, null, null), n, time.Elapsed);
                ciclo = error.Verdadero ?
                    !delMenorTolerancia(vReal, vActual) :
                    !delMenorTolerancia(vActual, vAnterior);
            } while (ciclo);
            time.Stop();
            return new Result(new RGeneric(vActual, null, null), n, time.Elapsed);
        }

        public static Result Trapecio(ParamFunc funcion, ParamError error)
        {
            Stopwatch time = new Stopwatch();
            var delMenorTolerancia = CErrorCalc.IsAceptable(error.Confianza);
            var delFuncion = JaceFunciones.Fx(funcion.Funcion, funcion.Parametro);
            bool ciclo;
            int n = (int)funcion.Incremento;
            double a = funcion.A, b = funcion.B, vActual = 0, vAnterior = 0, vReal = 0, deltaX;

            if (error.Verdadero)
                vReal = TeoremaCalculo(funcion);

            time.Start();
            do {
                vAnterior = vActual;
                vActual = 0;
                deltaX = (b - a) / n;

                for (double i = a + deltaX; i < b; i += deltaX) {               //Sumatoria de X1 hasta Xn-1
                    vActual += delFuncion(i);
                }
                vActual *= 2;                                                   //El resultado de la sumatoria se multiplica por 2
                vActual += (delFuncion(a) + delFuncion(b));                           //se añade la evaluacion para X0 y Xn

                vActual *= (deltaX / 2);                                          //Por ultimo se multiplica por deltaX/2
                n += (int)funcion.Incremento;
                if (error.TokenCancel.IsCancellationRequested)
                    return new Result(new RGeneric(null, null, null), n, time.Elapsed);
                ciclo = error.Verdadero ?
                    !delMenorTolerancia(vReal, vActual) :
                    !delMenorTolerancia(vActual, vAnterior);
            } while (ciclo);
            time.Stop();

            return new Result(new RGeneric(vActual, null, null), n, time.Elapsed);
        }

        public static Result Simpson(ParamFunc funcion, ParamError error)
        {
            Stopwatch time = new Stopwatch();
            var delMenorTolerancia = CErrorCalc.IsAceptable(error.Confianza);
            var delFuncion = JaceFunciones.Fx(funcion.Funcion, funcion.Parametro);
            bool ciclo;
            int n = (int)funcion.Incremento;
            double a = funcion.A, b = funcion.B, vActual = 0, vAnterior = 0, vReal = 0, deltaX;
            if (n % 2 == 1)
                n++;

            if (error.Verdadero)
                vReal = TeoremaCalculo(funcion);

            time.Start();
            do {
                double tempVActual = 0;
                vAnterior = vActual;
                vActual = 0;
                deltaX = (b - a) / n;

                for (double i = a + deltaX; i < b; i += (2 * deltaX)) {         //Sumatoria de los Xi impares 
                    tempVActual += delFuncion(i);                                  //Esto se almacenara en una variable temporal
                }
                tempVActual *= 4;                                               //Al resultado se multiplica por 4

                for (double i = a + 2 * deltaX; i < b; i += (2 * deltaX)) {     //Sumatoria de los X pares excepto el Xn
                    vActual += delFuncion(i);
                }
                vActual *= 2;                                                   //Solamente al resultado de esta sumatoria se multiplica por 2

                vActual += (delFuncion(a) + delFuncion(b) + tempVActual);             //Al reusltado anterior le sumamos el resultado de la primera sumatoria
                                                                                //ademas, de los valores para X0 y Xn
                vActual *= (deltaX / 3);                                        //Por ultimo todo esto es multiplicado por deltaX/3
                n += (int)funcion.Incremento;                                                         //n debe ser par por lo tanto se va multiplicando por 2
                if (error.TokenCancel.IsCancellationRequested)
                    return new Result(new RGeneric(null, null, null), n, time.Elapsed);
                ciclo = error.Verdadero ?
                    !delMenorTolerancia(vReal, vActual) :
                    !delMenorTolerancia(vActual, vAnterior);
            } while (ciclo);
            time.Stop();

            return new Result(new RGeneric(vActual, null, null), n, time.Elapsed);
        }

        public static Result MonteCarlo(ParamFunc funcion, double cota, ParamError error)
        {
            var rnd = new Random();
            Stopwatch time = new Stopwatch();
            List<Point> puntosExito = new List<Point>();
            List<Point> puntosFallo = new List<Point>();
            var delMenorTolerancia = CErrorCalc.IsAceptable(error.Confianza);
            var delFuncion = JaceFunciones.Fx(funcion.Funcion, funcion.Parametro);

            bool ciclo;
            int n = (int)funcion.Incremento, nAnterior = 0;     //nanterior para optimizar el tiempo de generacion de puntos
            double a = funcion.A, b = funcion.B, vActual = 0, vAnterior = 0, vReal = 0, x, y;

            if (error.Verdadero)
                vReal = TeoremaCalculo(funcion);

            time.Start();
            do {
                double fx;
                vAnterior = vActual;
                for (int i = nAnterior; i < n; i++) {
                    x = a + rnd.NextDouble() * (b - a);
                    y = rnd.NextDouble() * cota;
                    fx = delFuncion(x);
                    if (y * fx >= 0 && Math.Abs(y) <= Math.Abs(fx))
                        puntosExito.Add(new Point(x, y));
                    else
                        puntosFallo.Add(new Point(x, y));
                }

                vActual = (puntosExito.Count / (double)n) * (cota * (b - a));
                nAnterior = n;
                n += (int)funcion.Incremento;
                if (error.TokenCancel.IsCancellationRequested)
                    return new Result(new RGeneric(null, null, null), n, time.Elapsed);

                ciclo = error.Verdadero ?
                    !delMenorTolerancia(vReal, vActual) :
                    !delMenorTolerancia(vActual, vAnterior);
            } while (ciclo);
            time.Stop();

            return new Result(new RGeneric(vActual, puntosExito, puntosFallo), n, time.Elapsed);
        }

        private static double TeoremaCalculo(ParamFunc funcion)
        {
            var terminos = new GrafoTerminos(
                    null, new GrafoTokens(null, funcion.Funcion)
                        .TokenList())
                    .TerminoList();
            string j = "";
            foreach (var termino in terminos) {
                termino.Exponente++;
                termino.Coeficiente /= termino.Exponente;
                j += termino.TerminoString();
            }
            var delIntgrIndef = JaceFunciones.Fx(j.TrimStart('+'), "x");
            return delIntgrIndef(funcion.B) - delIntgrIndef(funcion.A);
        }
    }
}
