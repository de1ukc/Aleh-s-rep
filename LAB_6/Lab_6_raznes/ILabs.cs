namespace Lab_6_raznes
{
    public interface ILabs
    {
        void PassTheLab();
        void CreateTheLab();
    }

    public interface Comp<T,T1>
    {
        int Comparator(T a, T1 b);
    }

    public interface IGames
    {
        void Cards();
        void RussianRoulette();
    }
}