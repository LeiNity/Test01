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
            //TODO:������Բ���һ��Splash����
            if (GameEntry.Base.EditorResourceMode)
            {
                GameEntry.Messenger.SendEvent(EventName.EVENT_CS_UI_REFRESH_INITFORM, UILanguage.START_SPLASH);
                ChangeState<ProcedurePreload>(procedureOwner);
                // �ɸ���ģʽ
                /*                Log.Info("Updatable resource mode detected.");
                                ChangeState<ProcedureCheckVersion>(procedureOwner);*/
            }else if(GameEntry.Resource.ResourceMode == ResourceMode.Package)
            {
                //����ģʽ
                Log.Error("����ģʽ Package resource mode detected.");
                //ChangeState<ProcedureInitResources>(procedureOwner);
            }
            else
            {
                // �ɸ���ģʽ
                Log.Error("�ɸ���ģʽ Updatable resource mode detected.");
                //ChangeState<ProcedureCheckVersion>(procedureOwner);
            }
        }

    }
}