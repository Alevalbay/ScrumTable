using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TaskDetailSave : MonoBehaviour
{
    public Data datalar;

    public InputField Taskname_1;
    public InputField Taskname_2;
    public InputField Taskname_3;
    public InputField Taskname_4;
    public InputField Taskname_5;
    public InputField Taskname_6;
    public InputField Taskname_7;
    public InputField Taskname_8;
    public InputField Taskname_9;   
    public InputField Taskname_10;
    public InputField Taskexplain_1;
    public InputField Taskexplain_2;
    public InputField Taskexplain_3;
    public InputField Taskexplain_4;
    public InputField Taskexplain_5;
    public InputField Taskexplain_6;
    public InputField Taskexplain_7;
    public InputField Taskexplain_8;
    public InputField Taskexplain_9;
    public InputField Taskexplain_10;
    public InputField TaskMadeBy_1;
    public InputField TaskMadeBy_2;
    public InputField TaskMadeBy_3;
    public InputField TaskMadeBy_4;
    public InputField TaskMadeBy_5;
    public InputField TaskMadeBy_6;
    public InputField TaskMadeBy_7;
    public InputField TaskMadeBy_8;
    public InputField TaskMadeBy_9;
    public InputField TaskMadeBy_10;

    public TaskDetailSave(Data dt)
    {
        this.datalar = dt;
    }

    public void trasferData()
    {


        Taskname_1.text = datalar.TaskName1;
        Taskname_2.text = datalar.TaskName2;
        Taskname_3.text = datalar.TaskName3;
        Taskname_4.text = datalar.TaskName4;
        Taskname_5.text = datalar.TaskName5;
        Taskname_6.text = datalar.TaskName6;
        Taskname_7.text = datalar.TaskName7;
        Taskname_8.text = datalar.TaskName8;
        Taskname_9.text = datalar.TaskName9;
        Taskname_10.text = datalar.TaskName10;
        Taskexplain_1.text = datalar.TaskExplain1;
        Taskexplain_2.text = datalar.TaskExplain2;
        Taskexplain_3.text = datalar.TaskExplain3;
        Taskexplain_4.text = datalar.TaskExplain4;
        Taskexplain_5.text = datalar.TaskExplain5;
        Taskexplain_6.text = datalar.TaskExplain6;
        Taskexplain_7.text = datalar.TaskExplain7;
        Taskexplain_8.text = datalar.TaskExplain8;
        Taskexplain_9.text = datalar.TaskExplain9;
        Taskexplain_10.text = datalar.TaskExplain10;
        TaskMadeBy_1.text = datalar.MadeBy1;
        TaskMadeBy_2.text = datalar.MadeBy2;
        TaskMadeBy_3.text = datalar.MadeBy3;
        TaskMadeBy_4.text = datalar.MadeBy4;
        TaskMadeBy_5.text = datalar.MadeBy5;
        TaskMadeBy_6.text = datalar.MadeBy6;
        TaskMadeBy_7.text = datalar.MadeBy7;
        TaskMadeBy_8.text = datalar.MadeBy8;
        TaskMadeBy_9.text = datalar.MadeBy9;
        TaskMadeBy_10.text = datalar.MadeBy10;

    }

}


