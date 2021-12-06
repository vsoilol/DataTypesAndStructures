namespace Lab5.Providers
{
    internal interface IUIProvider
    {
        int GetIntData(string message);
        
        void ShowMessage(string message);
    }
}