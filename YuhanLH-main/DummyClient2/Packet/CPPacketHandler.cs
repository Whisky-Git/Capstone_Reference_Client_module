using DummyClient2;
using System;
using System.Drawing;

class PacketHandler
{

    public static void SP_ResultHandler(PacketSession session, IPacket packet)
    {
        SP_Result result = packet as SP_Result;
        ServerSession serverSession = session as ServerSession;       
       
    }
    
    public static void SP_LoginFailedHandler(PacketSession session, IPacket packet)
    {
        SP_LoginFailed pkt = packet as SP_LoginFailed;

        Console.WriteLine(pkt.result + "�� ���� ����");
    }     
    public static void SP_LoginResultHandler(PacketSession session, IPacket packet)
    {
        SP_LoginResult pkt = packet as SP_LoginResult;
        Console.WriteLine("�α��� ����");
        Console.WriteLine("��ü ���� ����");
        foreach(SP_LoginResult.Lecture lec in pkt.lectures)
        {
            Console.WriteLine( $"{lec.lecture_code} {lec.credit} {lec.lecture_name} {lec.professor_id} {lec.strat_time} {lec.end_time}");

        }
        foreach(SP_LoginResult.Student student in pkt.students)
        {
            Console.WriteLine($"{student.lectureCode} {student.studentId} {student.studentName}");
        }


    }
    public static void SP_StudentInfoHandler(PacketSession session, IPacket packet)
    {
        SP_StudentInfo pkt = packet as SP_StudentInfo;
        foreach (SP_StudentInfo.Student s in pkt.students)
        {
            Console.WriteLine(s.studentId);
        } 
    }

    public static void SP_ScreenResultHandler(PacketSession session, IPacket packet)
    {
        SP_ScreenResult sp_screenPacket = packet as SP_ScreenResult;
        ServerSession serverSession = session as ServerSession;

        Console.WriteLine("�̹��� �ޱ�");
        Console.WriteLine(sp_screenPacket.studentId);
        Console.WriteLine(sp_screenPacket.img);
    
    }
    public static void SP_QustionTextHandler(PacketSession session, IPacket packet)
    {
        SP_QustionText pkt = packet as SP_QustionText;
        Console.WriteLine("���� �� : " + pkt.studentId + "�� " + pkt.qustion);
    }
    public static void SP_QustionImgHandler(PacketSession session, IPacket packet)
    {
        SP_QustionImg pkt = packet as SP_QustionImg;
        Console.WriteLine("���� �� : " + pkt.studentId + "�� " + pkt.img);
    }
    public static void SP_QustionHandler(PacketSession session, IPacket packet)
    {
        SP_Qustion pkt = packet as SP_Qustion;
        Console.WriteLine("���� �� : " + pkt.studentId + "�� " + pkt.img + " ��" + pkt.qustion);
    }
    public static void SP_QuizResultHandler(PacketSession session, IPacket packet)
    {
        SP_QuizResult pkt = packet as SP_QuizResult;
        Console.WriteLine("���� ���� : " + pkt.studentId + "��" + pkt.result);
    }
    public static void SP_EndClassHandler(PacketSession session, IPacket packet)
    {
        
    }
    public static void SP_QuizOXResultHandler(PacketSession session, IPacket packet)
    {
        SP_QuizOXResult pkt = packet as SP_QuizOXResult;
        Console.WriteLine("���� ���� : " + pkt.studentId + "��" + pkt.result);
    }
    public static void SP_AddStudentHandler(PacketSession session, IPacket packet)
    {
        SP_AddStudent pkt = packet as SP_AddStudent;
        Console.WriteLine("����");
        Console.WriteLine($"{pkt.studentId} : ����" );
    }
    public static void SP_LeaveStudentHandler(PacketSession session, IPacket packet)
    {
        SP_LeaveStudent pkt = packet as SP_LeaveStudent;
        Console.WriteLine(pkt.studentId + "����");
    }
    public static void SP_AddAtdHandler(PacketSession session, IPacket packet)
        {
        SP_AddAtd pkt = packet as SP_AddAtd;

        Console.WriteLine("�л� �⼮ : " + pkt.studentId);
        }
    public static void SP_AtdListHandler(PacketSession session, IPacket packet)
    {
        SP_AtdList pkt = packet as SP_AtdList;
        Console.WriteLine("�⼮�� ����");
        foreach(SP_AtdList.AtdList a in pkt.atdLists)
        {
            Console.WriteLine($"�⼮�� :  {a.studentId} week : {a.week} {a.first_class} {a.second_class} {a.third_class}" );
        }
        
    }


}