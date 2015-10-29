using System;

namespace Builder
{
    class Foreman
    {
        Builder builder;

        public Foreman(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            // ��������� ���� ������� ��������� � ���������� �������.
            // ������� ������� ������, ����� ���� � � ��������� ������� �����.
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
