using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTask
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine( "Please enter an odd number between 3 and 9999:" );
                num = checkInput( Console.ReadLine() );
            } while ( num == 0 );

            printLogo(num);
        }

        static int checkInput( string num ) {
            int n = 0;
            if ( !int.TryParse( num , out n ))
            {
                return 0;
            }

            if ( n < 3 || n > 10000 || n%2==0 )
            {
                return 0;
            }
            return n;
        }

        static void printSymbol( char c, int n ) {
            for ( int i = 0; i < n; i++ )
            {
                Console.Write( c );
            }
        }

        static void printUpperPart( int n ) {

            for ( int i = 0; i < (n + 1) / 2; i++ )
            {
                for (int j = 0; j < 2; j++)
                {
                    printSymbol( '-', n - i);

                    printSymbol( '*', n + ( i * 2 ));

                    printSymbol( '-', n - ( i * 2 ));

                    printSymbol( '*', n + ( i * 2 ));

                    printSymbol( '-', n - i );

                }

                Console.WriteLine();
            }
        }

        static void printLowerPart( int n )
        {
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    printSymbol( '-', (( n + 1 ) / 2 ) - ( 1 + i ));

                    printSymbol( '*', n );

                    printSymbol( '-', ( i * 2 ) + 1 );

                    printSymbol( '*', ( n * 2 ) - ( i * 2 ) - 1 );

                    printSymbol( '-', ( i * 2 ) + 1 );

                    printSymbol( '*', n );

                    printSymbol('-', (( n + 1 ) / 2 ) - ( 1 + i ));
                }

                Console.WriteLine();
            }
        }

        static void printLogo( int n ) {
            printUpperPart( n );
            printLowerPart( n );
        }
    }
}
