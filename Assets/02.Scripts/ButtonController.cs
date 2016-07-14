﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    

    public void explore()
    {
        Debug.Log("행성을 탐사합니다!");
        //Vector3 spawnPoint = GameManager.Instance().planetSpawnPoint;

        //충돌한 물음표 행성 비활성화
        GameManager.Instance().tempPlanet.SetActive(false);

        //행성 생성
        Debug.Log("<b>SpawnPoint!!</b> " + GameManager.Instance().planetSpawnPoint);
        PlanetManager script = GameObject.Find("PlanetManager").GetComponent<PlanetManager>();
        script.planetChange(GameManager.Instance().planetSpawnPoint);

        //탐사 UI 비활성화
        GameManager.Instance().exploreUi.SetActive(false);

        //Scene 전환 추가예정
    }

    public void pass()
    {
        //게임 시간 초기화
        Time.timeScale = 1;

        //행성 생성하지 않음
        GameManager.Instance().tempPlanet.SetActive(false);
        //탐사 UI 비활성화
        GameManager.Instance().exploreUi.SetActive(false);
    }

    public void TransSceneToMain()
    {
        SceneManager.LoadScene("Main");
        DontDestroyOnLoad(GameObject.Find("GameData").gameObject);
        Debug.Log("scene Trans to Main");
    }

    public void TransSceneToShop()
    {
        //SceneManager.LoadScene("shop");
        DontDestroyOnLoad(GameObject.Find("GameData").gameObject);
        Debug.Log("scene Trans to shop");
    }


    public void TransSceneToBook()
    {
        //SceneManager.LoadScene("Book");
        DontDestroyOnLoad(GameObject.Find("GameData").gameObject);
        Debug.Log("scne trans to Book");
    }

    public void TransSceneToMap()
    {
        SceneManager.LoadScene("WorldMap");
        DontDestroyOnLoad(GameObject.Find("GameData").gameObject);
        Debug.Log("scene trans to WorldMap");
    }

    public void TransSceneToExplore()
    {
        SceneManager.LoadScene("Explore");
        DontDestroyOnLoad(GameObject.Find("GameData").gameObject);
        Debug.Log("scene Trans to Explore");
    }

    public void ReChoose()
    {
        WorldMapManager.Instance().Touch.SetActive(true);
        WorldMapManager.Instance().Destination_ui.SetActive(false);
    }
    public void VisibleSetting()
    {
        GameObject.Find("Canvas").transform.FindChild("SettingPanal").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("DragZone").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(true);
        GameObject planet = GameObject.Find("death_planet");
        planet.gameObject.layer = 2;
    }


    public void Confirm()
    {
        Debug.Log("confirm");
        GameObject.Find("Canvas/SettingPanal").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.FindChild("DragZone").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(false);
        GameObject planet = GameObject.Find("death_planet");
        planet.gameObject.layer = 0;

        csScreenPointTouch.rDrag = true;


    }

    public void Cancel()
    {
        Debug.Log("Cancel");
        GameObject.Find("Canvas/SettingPanal").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.FindChild("DragZone").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(false);
        GameObject planet = GameObject.Find("death_planet");
        planet.gameObject.layer = 0;

        csScreenPointTouch.rDrag = true;


    }

    public void TransSceneToWorldMap()
    {
        //SceneManager.LoadScene("WorldMap");
        Debug.Log("scene Trans to WorldMap");
    }


    public void VisibleSettingInStar()
    {
        GameObject.Find("Canvas").transform.FindChild("SettingPanal").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(true);
    }


    public void ConfirmInStar()
    {
        Debug.Log("confirm");
        GameObject.Find("Canvas/SettingPanal").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(false);



    }

    public void CancelInStar()
    {
        Debug.Log("Cancel");
        GameObject.Find("Canvas/SettingPanal").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.FindChild("BlockPanal").gameObject.SetActive(false);



    }
    

}
