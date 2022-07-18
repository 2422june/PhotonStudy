using Photon.Pun;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager inst { get; private set; }

    [Header("==Panel==")]
    [SerializeField]
    GameObject titlePanel;
    [SerializeField]
    GameObject lobbyPanel;
    [SerializeField]
    GameObject inGamePanel;

    [Space(10)]

    [Header("==Element of title==")]
    [SerializeField]
    GameObject inputNameField;
    [SerializeField]
    InputField inputField;

    [Space(10)]

    [Header("==Element of InGame==")]
    [SerializeField]
    Text InGameText;
    string InGameString = "Now InGame...";

    public enum State
    {
        title,
        lobby,
        inGame
    }

    public State state;

    void Awake()
    {
        SetState("title");
    }

    void SetState(string state)
    {
        lobbyPanel.SetActive(false);
        inGamePanel.SetActive(false);
        titlePanel.SetActive(false);

        if (state.Equals("title"))
        {
            this.state = State.title;
            titlePanel.SetActive(true);
            inputField = inputNameField.GetComponent<InputField>();
        }
        if (state.Equals("lobby"))
        {
            this.state = State.lobby;
            lobbyPanel.SetActive(true);
        }
        if (state.Equals("inGame"))
        {
            this.state = State.inGame;
            inGamePanel.SetActive(true);
        }
    }

    public void OnClickConnect()
    {
        if (inputField.text.Equals(""))
        {
            inputField.text = "닉네임을 입력해 주세요.";
        }
        else
        {
            PhotonNetwork.NickName = inputField.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public void OnClickStart()
    {
        if (state != State.inGame)
        {
            SetState("inGame");
            PhotonNetwork.JoinRandomOrCreateRoom(
                null, 1, Photon.Realtime.MatchmakingMode.FillRoom,
                null, null, "firstRoom",
                new Photon.Realtime.RoomOptions { MaxPlayers = 1 });
        }
        else
        {
            SetState("lobby");
            PhotonNetwork.LeaveRoom();
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("Anybody Enter");
        if(PhotonNetwork.CurrentRoom.MaxPlayers == PhotonNetwork.CurrentRoom.PlayerCount)
        {
            Debug.Log("Let's Game Start!!!");
            //PhotonNetwork.Instantiate();
        }
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("Anybody Leave");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SetState("lobby");
    }

}