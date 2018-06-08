namespace csharp_tutorial_10
{
    //model what happens when a button is pressed (tutorial 10)
    interface Icommand
    {
        void Execute();
        void Undo();
    }
}
