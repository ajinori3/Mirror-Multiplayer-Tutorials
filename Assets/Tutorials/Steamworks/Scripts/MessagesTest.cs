using Mirror;
using System;
using TMPro;
using UnityEngine;

namespace DapperDino.Mirror.Tutorials.Steamworks
{
    public struct Notification : NetworkMessage
    {
        public string content;
    }

    public class MessagesTest : MonoBehaviour
    {
        [SerializeField] private TMP_Text notificationsText = null;

        private void Start()
        {
            if (!NetworkClient.active) { return; }

            NetworkClient.RegisterHandler<Notification>(OnNotification);
        }

        private void OnNotification(Notification msg)
        {
            notificationsText.text += $"\n{msg.content}";
        }
    }
}
