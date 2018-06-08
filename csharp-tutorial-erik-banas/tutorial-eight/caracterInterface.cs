namespace csharp_tutorial_8
{   
    interface CaracterInterface
    {
        
        int GetHealth();
        int GetDefensePower();
        string GetName();
        void SetHealth(int health);
        void Attack(ref CaracterInterface enemy);
        void Defense(ref CaracterInterface enemy);
    }
}
