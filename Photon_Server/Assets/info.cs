/*
 
���� :
�������� Ŭ���̾�Ʈ�� 100����� ����,
������ ��ǻ�͸� �׻� Ű�ų� �ܺ� �ַ�ǰ� ������ ����ϴ� ����

Ŭ���̾�Ʈ�� PUN2�� ���� IP�� �����Ѵ�

������ ����� �ݹ��Լ��� �ý����� �̷���� �ִ�.
�� �Լ����� �������̵� �ؼ� ������ �Ͽ� ����Ѵ�.

======================================================================


PhotonNetwork.ConnectUsingSettings(); �¶��� ����

public override void OnConnectedToMaster() �¶��� ���� �Ϸ�

PhotonNetwork.JoinLobby(); �κ� ����

public override void OnJoinedLobby() �κ� ���� �Ϸ�

PhotonNetwork.JoinRandomOrCreateRoom(); �� ����

public override void OnPlayerEnteredRoom(Player newPlayer) ���ο� �÷��̾� ����

public override void OnPlayerLeftRoom(Player otherPlayer) ���� �÷��̾� ����

PhotonNetwork.PlayerList ���� ��� �÷��̾��� ���

PhotonNetwork.CurrentRoom.PlayerCount ���� ���� �÷��̾��� ��

PhotonNetwork.CurrentRoom.Players ���� ���� �÷��̾��� ���

PhotonNetwork.CurrentRoom.MaxPlayers ���� ���� �ִ� �÷��̾� ��

if(photonView.IsMine) �� ��ũ��Ʈ�� �����ִ� ��ü�� ���� �÷��̾��� ��ü���?

*/