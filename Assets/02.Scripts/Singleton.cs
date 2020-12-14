using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton
{
    //싱글톤패턴 사용을 위해 만듦. 다른 스크립트에서 클래스 불러오기 가능.
    private Singleton() { }

    public static Singleton instance;

    public static Singleton getInstance 
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    // 인게임 점수
    private int count = 0;

    // 메인화면 총 점수
    private int totalCount = 0;

    // 메인화면 최고기록
    private int bestScore = 0;

    // 인게임 점수 가져오기
    public int getCount()
    {
        return count;
    }

    // 인게임 점수 1 증가
    public void increaseCount()
    {
        count++;
       
    }

    // 인게임 점수 초기화
    public void initCount()
    {
        count = 0;
    }

    public int getTotalCount()
    {
        return totalCount;
    }

    // 메인화면 총 점수 + 인게임 점수
    public void sumTotalCount(int count)
    {
        totalCount = totalCount + count;
    }

    public void minusTotalCount(int count)
    {
        totalCount = totalCount - count;
    }

    //메인화면 총 점수 + 광고 코인
    public void sumAdCount(int Ad = 10)
    {
        totalCount = totalCount + Ad;
    }
}

