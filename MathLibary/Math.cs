using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibary {
    class Math {
        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Subtract(int a, int b) {
            return a - b;
        }
        public static int Multiply(int a, int b) {
            return a * b;
        }
        public static int Divide(int a, int b) {
            return a / b;
        }
        public static int Modulo(int a, int b) {
            return a - (a / b * b);
        }
        public static int Power(int a, int b) {
            var answer = 1;
            for( var idx = 0; idx < b; idx++) {
                answer *= a;
            }
            return answer;
        }
            
        public static bool IsEven(int a) {
            // you could also do if(Modulo(a, 2) == 0)  this is the peferable way to do it, don't dupilcate code 
              if( a - (a / 2 * 2) == 0) {
                return true;
            }else {
                return false;
                // you could also do this a ternary method as return (Modulo(a, 2) == 0) ? true : false;
            }
        }
        public static int Increment(int a) {
            return a + 1;
        }
        public static int Decrement(int a) {
            return a - 1;
        }
            
    }
}
