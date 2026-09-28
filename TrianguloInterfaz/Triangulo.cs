using System;

namespace TrianguloInterfaz
{
    class Triangulo
    {
        private float baseTri;
        private float altura;

        public Triangulo() { baseTri = 0; altura = 0; }
        public Triangulo(float baseTri, float altura)
        {
            this.baseTri = baseTri;
            this.altura = altura;
        }

        public float Base { get { return baseTri; } set { baseTri = value; } }
        public float Altura { get { return altura; } set { altura = value; } }

        public float Area()
        {
            return (baseTri * altura) / 2;
        }

        public float Perimetro()
        {
            float hipotenusa = (float)Math.Sqrt(baseTri * baseTri + altura * altura);
            return baseTri + altura + hipotenusa;
        }
    }
}