namespace Lab_6_raznes
{
    public interface ILabs
    {
        void pass_the_lab();
        void create_the_lab();
    }

    public interface Comp<T,T1>
    {
        int Comparator(T a, T1 b);
    }
}