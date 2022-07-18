/*
 
포톤 :
동시접속 클라이언트가 100명까지 무료,
서버용 컴퓨터를 항상 키거나 외부 솔루션과 연결해 사용하는 서버

클라이언트는 PUN2나 서버 IP에 열결한다

포톤은 버츄얼 콜백함수를 궁심으로 이루어져 있다.
이 함수들을 오버라이드 해서 재정의 하여 사용한다.

======================================================================


PhotonNetwork.ConnectUsingSettings(); 온라인 접속

public override void OnConnectedToMaster() 온라인 접속 완료

PhotonNetwork.JoinLobby(); 로비에 접속

public override void OnJoinedLobby() 로비 접속 완료

PhotonNetwork.JoinRandomOrCreateRoom(); 방 생성

public override void OnPlayerEnteredRoom(Player newPlayer) 새로운 플레이어 입장

public override void OnPlayerLeftRoom(Player otherPlayer) 기존 플레이어 퇴장

PhotonNetwork.PlayerList 현재 모든 플레이어의 목록

PhotonNetwork.CurrentRoom.PlayerCount 현재 룸의 플레이어의 수

PhotonNetwork.CurrentRoom.Players 현재 룸의 플레이어의 목록

PhotonNetwork.CurrentRoom.MaxPlayers 현재 룸의 최대 플레이어 수

if(photonView.IsMine) 이 스크립트를 갖고있는 객체가 현재 플레이어의 객체라면?

*/