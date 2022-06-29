namespace Assets.Scripts
{
    internal interface IAlive
    {
        int Hp { get; set; }

        void TakeDamage(int damage);
    }
}
