namespace Skilvul {
    public class MyMath {
        float n1, n2;

        public MyMath(float n1, float n2) {
            this.n1 = n1;
            this.n2 = n2;
        }

        public float Add() {
            return n1+n2;
        }

        public float Substract() {
            return n1-n2;
        }

        public float Multiply() {
            return n1*n2;
        }

        public float Divide() {
            return n1/n2;
        }
    }
}