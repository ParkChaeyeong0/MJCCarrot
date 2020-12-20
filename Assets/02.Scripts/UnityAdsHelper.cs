using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using UnityEngine.UI;
public class UnityAdsHelper : MonoBehaviour
{
    private const string android_game_id = "3933763";
    private const string ios_game_id = "3933762";

    private const string rewarded_video_id = "rewardedVideo";
    public Image lockImg;

    [SerializeField]
    public Text Score;

    public int count;
    public int totalCount;

    void Start()
    {
        Initialize();
        lockImg.gameObject.SetActive(false);
    }


    IEnumerator AdsCoolTime()
    {
        yield return new WaitForSeconds(30f);
        lockImg.gameObject.SetActive(false);
    }

    private void Initialize()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(android_game_id);
#elif UNITY_IOS
        Advertisement.Initialize(ios_game_id);
#endif
    }

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady(rewarded_video_id))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };

            Advertisement.Show(rewarded_video_id, options);
        }

        lockImg.gameObject.SetActive(true);
        StartCoroutine(AdsCoolTime());

    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                {
                    Debug.Log("The ad was successfully shown.");

                    totalCount = totalCount + 10;

                    Debug.Log("성공");

                    // 광고 시청이 완료되었을 때 처리

                    break;
                }
            case ShowResult.Skipped:
                {
                    Debug.Log("스킵");
                    // 광고가 스킵되었을 때 처리

                    break;
                }
            case ShowResult.Failed:
                {
                    // 광고 시청에 실패했을 때 처리
                    break;
                }
        }

  

      
    }

    


}