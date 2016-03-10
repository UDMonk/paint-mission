using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        MessageHandler msgHandler = GetComponent<MessageHandler>();

        if (msgHandler)
        {
            msgHandler.RegisterDelegate(RecieveMessage);
        }
    }


    void RecieveMessage(MessageType msgType, GameObject go, MessageData msgData)
    {
        switch (msgType)
        {
            case MessageType.DIED:
                DeathData dthData = msgData as DeathData;

                if (dthData != null)
                {
                    Die();
                }
                break;
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}