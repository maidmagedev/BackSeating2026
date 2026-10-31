using UnityEngine;
using Lexone.UnityTwitchChat;
using System;
public class TwitchChatHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IRC.Instance.OnChatMessage += OnChatMessage;
    }

    private void OnChatMessage(Chatter chatter)
    {
        // Handle new chat messages...
        Debug.Log($"<color=#fef83e><b>[LISTENER EXAMPLE]</b></color> New chat message from {chatter.tags.displayName}");

    }

}
