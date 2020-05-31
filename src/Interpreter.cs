using System;
using System.Collections.Generic;
using System.Text;

namespace Scheme4cs {
    public class Interpreter {
        public object Eval(object x, Env env) {
            while (true) {
                if (x is Cell) {
                    var func = x.Car();
                    var args = x.Cdr();
                    if (func.Equals("quote")) {
                        return args.Car();
                    }
                } else if (x is string) {

                } else {

                }
            }
        }
    }
}
