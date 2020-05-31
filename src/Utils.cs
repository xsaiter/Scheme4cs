namespace Scheme4cs {
    public static class Utils {
        public static object Car(this object x) => (x as Cell)?.First;

        public static object Cdr(this object x) => (x as Cell)?.Rest;

        public static object Second(this object x) => Car(Cdr(x));
    }
}
