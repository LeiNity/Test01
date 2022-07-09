using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Deer
{
    public class ProcedureLauncher : ProcedureBase
    {
        public override bool UseNativeDialog { get { return false; } }
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.Messenger.SendEvent(EventName.EVENT_CS_UI_REFRESH_INITFORM, UILanguage.START_GAME);
            ChangeState<ProcedureSplash>(procedureOwner);
        }
    }
}
