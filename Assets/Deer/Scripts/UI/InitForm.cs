using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitForm : MonoBehaviour
{

    public Text m_Content;
    
    void Start()
    {
        GameEntry.Messenger.RegisterEvent(EventName.EVENT_CS_UI_REFRESH_INITFORM, RefreshInitForm);
        GameEntry.Messenger.RegisterEvent(EventName.EVENT_CS_UI_OPEN_INITFORM_UI, OpenUiInitFormPanel);
    }

    
    void OnDestroy()
    {
        GameEntry.Messenger.UnRegisterEvent(EventName.EVENT_CS_UI_REFRESH_INITFORM, RefreshInitForm);
        GameEntry.Messenger.UnRegisterEvent(EventName.EVENT_CS_UI_OPEN_INITFORM_UI, OpenUiInitFormPanel);
    }

    object RefreshInitForm(object pSender)
    {
        if (m_Content == null)
        {
            return null;
        }
        string content = (string)pSender;
        if (!string.IsNullOrEmpty(content)) 
        {
            m_Content.text = content;
        }
        return null;
    }

    object OpenUiInitFormPanel(object pSender)
    {
        if (pSender is MessengerInfo messengerInfo)
        {
            bool bIsOpen = bool.Parse(messengerInfo.param1.ToString());
            gameObject.SetActive(bIsOpen);
        }
        return null;
    }
}
