using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example01 : MonoBehaviour
{
    // 1. 클래스 선언 (멤버변수, 멤버메소드, 생성자)
    // 2. 클래스 인스턴스 (생성자를 매개변수 호출)
    // 3. 클래스 멤버변수 호출
    // Start is called before the first frame update
    void Start()
    {
        Student student = new Student("김은규", 28, "수원시");
        Debug.Log("이름 : " + student.GetName());
        Debug.Log("나이 : " + student.GetAge());
        Debug.Log("주소 : " + student.GetAddress());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// 접근지정자 class 클래스의이름
public class Student
{
    // 멤버변수
    private string name;
    private int age;
    private string address;

    // 생성자 클래스의 멤버변수를 초기화해주는 역할을 합니다.
    // 클래스가 생성되었을 때 호출이 됩니다.
    // 접근지정자 클래스이름(매개변수타입 매개변수이름)
    public Student(string iName, int iAge, string iAddress)
    {
        name = iName;
        age = iAge;
        address = iAddress;
    }

    // 멤버 메소드
    // 접근지정자 반환형(변수타입) 함수이름(매개변수타입 매개변수이름)
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetAddress()
    {
        return address;
    }
}