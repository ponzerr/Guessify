using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
	
	public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	public void BackButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
	//-------------------------------------------------------------------------
	public void CategorytoFoodCategory(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //-------------------------------------------------------------------------
    public void Category_Level1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Category_Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Category_Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Category_Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Category_Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Category_Level6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void Category_Level7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void Category_Level8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void Category_Level9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
    public void Category_Level10()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
    public void Category_Level11()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
    public void Category_Level12()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }
    public void Category_Level13()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
    public void Category_Level14()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }
    public void Category_Level15()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }
    //-------------------------------------------------------------------------
    public void ActiveScene_CategoryMenu()
    {
        SceneManager.LoadScene("CategoryMenu");
    }

    public void ActiveScene_FoodCategory(){
        SceneManager.LoadScene("FoodCategory");
    }

    public void ActiveScene_LocationCategory()
    {
        SceneManager.LoadScene("LocationCategory");
    }

    public void ActiveScene_AnimalsCategory()
    {
        SceneManager.LoadScene("AnimalsCategory");
    }

    public void ActiveScene_CultureCategory()
    {
        SceneManager.LoadScene("CultureCategory");
    }

    public void ActiveScene_FilmCategory()
    {
        SceneManager.LoadScene("FilmCategory");
    }

    public void ActiveScene_MusicCategory()
    {
        SceneManager.LoadScene("MusicCategory");
    }

    public void ActiveScene_JobCategory()
    {
        SceneManager.LoadScene("JobCategory");
    }

    public void ActiveScene_CountryCategory()
    {
        SceneManager.LoadScene("CountryCategory");
    }

    public void ActiveScene_TechnoCategory()
    {
        SceneManager.LoadScene("TechnoCategory");
    }
}
