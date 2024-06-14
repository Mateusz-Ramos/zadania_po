using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    public class Macierz<T> : IEquatable<Macierz<T>>
    {
        private readonly T[,] _matrix;

        public int Wiersze { get; }
        public int Kolumny { get; }

        public Macierz(int wiersze, int kolumny)
        {
            if (wiersze <= 0 || kolumny <= 0)
                throw new ArgumentException("Wymiary macierzy musza byc dodatnie.");

            Wiersze = wiersze;
            Kolumny = kolumny;
            _matrix = new T[wiersze, kolumny];
        }

        public T this[int wiesz, int kolumna]
        {
            get
            {
                if (wiesz < 0 || wiesz >= Wiersze || kolumna < 0 || kolumna >= Kolumny)
                    throw new IndexOutOfRangeException("Indeks poza zakresem.");
                return _matrix[wiesz, kolumna];
            }
            set
            {
                if (wiesz < 0 || wiesz >= Wiersze || kolumna < 0 || kolumna >= Kolumny)
                    throw new IndexOutOfRangeException("Indeks poza zakresem.");
                _matrix[wiesz, kolumna] = value;
            }
        }

        public bool Equals(Macierz<T> other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(other, null)) return false;

            if (Wiersze != other.Wiersze || Kolumny != other.Kolumny)
                return false;

            for (int i = 0; i < Wiersze; i++)
            {
                for (int j = 0; j < Kolumny; j++)
                {
                    if (!EqualityComparer<T>.Default.Equals(_matrix[i, j], other._matrix[i, j]))
                        return false;
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Macierz<T>);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + Wiersze.GetHashCode();
            hash = hash * 31 + Kolumny.GetHashCode();

            foreach (var item in _matrix)
            {
                hash = hash * 31 + (item == null ? 0 : item.GetHashCode());
            }

            return hash;
        }

        public static bool operator ==(Macierz<T> left, Macierz<T> right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (ReferenceEquals(left, null)) return false;
            if (ReferenceEquals(right, null)) return false;

            return left.Equals(right);
        }

        public static bool operator !=(Macierz<T> left, Macierz<T> right)
        {
            return !(left == right);
        }
    }
}
