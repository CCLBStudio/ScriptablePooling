namespace CCLBStudio.ScriptablePooling
{
    public interface IScriptablePooledObject
    {
        public ScriptablePool Pool { get; set; }
        public void OnObjectCreated(ScriptablePool objectPool);
    }
}
