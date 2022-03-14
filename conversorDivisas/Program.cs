using System;

namespace currencyConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*---------------------------------------------------------------------------------------*");
            Console.WriteLine("*   ▄▀▄▄▄▄   ▄▀▀▀▀▄   ▄▀▀▄ ▀▄  ▄▀▀▄ ▄▀▀▄  ▄▀▀█▄▄▄▄  ▄▀▀▄▀▀▀▄  ▄▀▀▀▀▄  ▄▀▀▀▀▄   ▄▀▀▄▀▀▀▄ *");
            Console.WriteLine("*  █ █    ▌ █      █ █  █ █ █ █   █    █ ▐  ▄▀   ▐ █   █   █ █ █   ▐ █      █ █   █   █ *");
            Console.WriteLine("*  ▐ █      █      █ ▐  █  ▀█ ▐  █    █    █▄▄▄▄▄  ▐  █▀▀█▀     ▀▄   █      █ ▐  █▀▀█▀  *");
            Console.WriteLine("*    █      ▀▄    ▄▀   █   █     █   ▄▀    █    ▌   ▄▀    █  ▀▄   █  ▀▄    ▄▀  ▄▀    █  *");
            Console.WriteLine("*   ▄▀▄▄▄▄▀   ▀▀▀▀   ▄▀   █       ▀▄▀     ▄▀▄▄▄▄   █     █    █▀▀▀     ▀▀▀▀   █     █   *");
            Console.WriteLine("*  █     ▐           █    ▐               █    ▐   ▐     ▐    ▐               ▐     ▐   *");
            Console.WriteLine("*  ▐                 ▐  ▄▀▀█▄▄   ▄▀▀█▄▄▄▄ ▐                                             *");
            Console.WriteLine("*                      █ ▄▀   █ ▐  ▄▀   ▐                                               *");
            Console.WriteLine("*                      ▐ █    █   █▄▄▄▄▄                                                *");
            Console.WriteLine("*                        █    █   █    ▌                                                *");
            Console.WriteLine("*                       ▄▀▄▄▄▄▀  ▄▀▄▄▄▄                                                 *");
            Console.WriteLine("*                      █     ▐   █    ▐                                                 *");
            Console.WriteLine("*                      ▐         ▐                                                      *");
            Console.WriteLine("*       ▄▀▀▄ ▄▀▄  ▄▀▀▀▀▄   ▄▀▀▄ ▀▄  ▄▀▀█▄▄▄▄  ▄▀▀█▄▄   ▄▀▀█▄   ▄▀▀▀▀▄                   *");
            Console.WriteLine("*      █  █ ▀  █ █      █ █  █ █ █ ▐  ▄▀   ▐ █ ▄▀   █ ▐ ▄▀ ▀▄ █ █   ▐                   *");
            Console.WriteLine("*      ▐  █    █ █      █ ▐  █  ▀█   █▄▄▄▄▄  ▐ █    █   █▄▄▄█    ▀▄                     *");
            Console.WriteLine("*        █    █  ▀▄    ▄▀   █   █    █    ▌    █    █  ▄▀   █ ▀▄   █                    *");
            Console.WriteLine("*      ▄▀   ▄▀     ▀▀▀▀   ▄▀   █    ▄▀▄▄▄▄    ▄▀▄▄▄▄▀ █   ▄▀   █▀▀▀                     *");
            Console.WriteLine("*      █    █             █    ▐    █    ▐   █     ▐  ▐   ▐    ▐                        *");
            Console.WriteLine("*      ▐    ▐             ▐         ▐        ▐                                          *");
            Console.WriteLine("*---------------------------------------------------------------------------------------*");

            Console.WriteLine("*---------------------------------------------------------------------------------------*");
            Console.WriteLine("*---------------------Bienvenidos al conversor de monedas!------------------------------*");
            Console.WriteLine("*---------------------------------------------------------------------------------------*");

            //Declaramos el valor de cada moneda
            var eur = 1;
            var usd = 1.0912;
            var yen = 128.02;
            var btc = 0.000028;
            var eth = 0.00042;

            //El "var" no es dinamico así que hacemos una variable si podemos convertir para poder aplicarlo al while
            var canConvert = false;

            while (!canConvert)
            {
                Console.WriteLine("Introduce un valor en euros para convertir");
                eur = (int)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                //Preguntamos que moneda quiere convertir
                Console.WriteLine("Elige la moneda que quieres convertir o pulsa q para salir");
                Console.WriteLine("\t *-----------------------------------*");
                Console.WriteLine("\t EUR = Euro");
                Console.WriteLine("\t USD = Dolar");
                Console.WriteLine("\t YEN = Yen");
                Console.WriteLine("\t BTC = Bitcoin");
                Console.WriteLine("\t ETH = Ethereum");
                Console.WriteLine("\t *-----------------------------------*");

                //Metemos la STR por teclado, será la variable a convertir (o la "q" si queremos salir
                var str = Console.ReadLine();
                Console.WriteLine();

                //Añadimos un if/else donde dentro del else metemos todo el switch/case, la primera opción es
                //si le damos a la q salimos del programa, si no empezamos con el código
                if (str == "q")
                {
                    Console.WriteLine($"Gracias, bye!");
                    break;
                }
                else
                {
                    //Hacemos un switch / case
                    switch (str)
                    {
                        //Ponemos varias opciones en cada case, para que detecte minus y mayus
                        case "EUR":
                        case "eur":
                            Console.WriteLine($"{eur} euros en Euros son " + (eur * eur).ToString("N2") + "euros\n");
                            break;

                        case "USD":
                        case "usd":
                            Console.WriteLine($"{eur} euros en Dolares son " + (eur * usd).ToString("N2") + " dolares\n");
                            break;

                        case "YEN":
                        case "yen":
                            Console.WriteLine($"{eur} euros en Yenes son " + (eur * yen).ToString("N2") + " yenes\n");
                            break;

                        case "BTC":
                        case "btc":
                            Console.WriteLine($"{eur} euros en Bitcoins son " + (eur * btc).ToString("N2") + " bitcoins\n");
                            break;

                        case "ETH":
                        case "eth":
                            Console.WriteLine($"{eur} euros en Ethereums son " + (eur * eth).ToString("N2") + " ethereum\n");
                            break;

                    }
                }
            }
            return;
        }
    }
}