using GameFramework.Resource;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace Deer
{
    public class ProcedureSplash : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get
            {
                return false;
            }
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            //TODO:这里可以播放一个Splash动画
            if (GameEntry.Base.EditorResourceMode)
            {
                GameEntry.Messenger.SendEvent(EventName.EVENT_CS_UI_REFRESH_INITFORM, UILanguage.START_SPLASH);
                ChangeState<ProcedurePreload>(procedureOwner);
                // 可更新模式
                /*                Log.Info("Updatable resource mode detected.");
                                ChangeState<ProcedureCheckVersion>(procedureOwner);*/
            }else if(GameEntry.Resource.ResourceMode == ResourceMode.Package)
            {
                //单机模式
                Log.Error("单机模式 Package resource mode detected.");
                //ChangeState<ProcedureInitResources>(procedureOwner);
            }
            else
            {
                // 可更新模式
                Log.Error("可更新模式 Updatable resource mode detected.");
                //ChangeState<ProcedureCheckVersion>(procedureOwner);
            }
        }

    }
}