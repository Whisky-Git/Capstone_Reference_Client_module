using DummyClient3;
using System;
using System.Collections.Generic;
using System.Threading;

class PacketHandler
{

    public static void SS_ResultHandler(PacketSession session, IPacket packet)
    {
        SS_Result result = packet as SS_Result;
        ServerSession serverSession = session as ServerSession;
      
    }
    public static void SS_LoginFailedHandler(PacketSession session, IPacket packet)
    {
        SS_LoginFailed pkt = packet as SS_LoginFailed;
        Console.WriteLine("�α��� ���� : " + pkt.result);
        
    }     
    public static void SS_LoginResultHandler(PacketSession session, IPacket packet)
    {
        SS_LoginResult loginResult_packet = packet as SS_LoginResult;
        List<SS_LoginResult.Lecture> LectureResult = loginResult_packet.lectures;
        string nowtime = "1205";
        Console.WriteLine("�α��� ����");
        foreach(SS_LoginResult.Lecture result in LectureResult)
        {
            if (Convert.ToInt32(result.strat_time) <= Convert.ToInt32(nowtime) && Convert.ToInt32(result.end_time) >= Convert.ToInt32(nowtime))
            {

                if (result.weekday == "��")
                {

                   //���� ���� �ð�

                }
            }
        }
     
        
        
    }
    public static void SS_EnterRoomHandler(PacketSession session, IPacket packet)
    {
      
    }
    public static void SS_QResultHandler(PacketSession session, IPacket packet)
        {
            
        }     
        public static void SS_AtdRequestHandler(PacketSession session, IPacket packet)
        {
        SS_AtdRequest pkt = packet as SS_AtdRequest;
        Console.WriteLine("�⼮ üũ �ϼ��� : " + pkt.week + " " + pkt.classTime);
        }     
    public static void SS_QuizOXHandler(PacketSession session, IPacket packet)
    {
        SS_QuizOX pkt = packet as SS_QuizOX;
        Console.WriteLine("���� : " + pkt.quiz);
      
    }     
        public static void SS_QuizHandler(PacketSession session, IPacket packet)
        {
        SS_Quiz pkt = packet as SS_Quiz;
        Console.WriteLine("���� : " + pkt.quiz);

    }
        public static void SS_ImgSendFaildHandler(PacketSession session, IPacket packet)
        {

        }
    public static void SS_ScreenRequestHandler(PacketSession session, IPacket packet)
    {

        Thread.Sleep(1000);
        Program.sessionManager.ImgSend();


    }
    public static void SS_LogoutHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_EndOfClassHandler(PacketSession session, IPacket packet)
    {

    }
    public static void SS_QustionFaildHandler(PacketSession session, IPacket packet)
    {
        
    }

}