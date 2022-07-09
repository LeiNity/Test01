namespace Deer
{
    public abstract class ProcedureBase : GameFramework.Procedure.ProcedureBase
    {
        private bool currIsLuaProcedure = false;
        public bool IsLuaProcedure
        {
            get
            {
                return currIsLuaProcedure;
            }
            set
            {
                currIsLuaProcedure = value;
            }
        }
        public abstract bool UseNativeDialog
        {
            get;
        }
    }
}
