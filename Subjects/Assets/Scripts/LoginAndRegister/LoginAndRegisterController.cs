using Proyecto26;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginAndRegisterController : MonoBehaviour
{
    public TMP_InputField emailText;
    public TMP_InputField usernameText;
    public TMP_InputField passwordText;
    public TMP_InputField passwordText1;

    public TMP_Text _errorMessage;
    public TMP_Text _emailErrorMessage;

    User user = new User();

    private string databaseURL = "https://revision-89e96-default-rtdb.firebaseio.com/";
    private string AuthKey = "AIzaSyD739W2en97TuP6cLzDPb1lt-tRxyASzM0";

    private string emailActionLink = "https://revision-89e96.firebaseapp.com/__/auth/action";

    public static fsSerializer serializer = new fsSerializer();

    private string idToken;

    public static string localId;

    private string getLocalId;


    public void OnSubmit()
    {
        PostToDatabase();
    }

    public void OnGetScore()
    {
        GetLocalId();
    }



    private void PostToDatabase(bool emptyScore = false, string idTokenTemp = "")
    {
        RestClient.Put(databaseURL + "/" + localId + ".json?auth=" + idTokenTemp, user);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User>(databaseURL + "/" + getLocalId + ".json?auth=" + idToken).Then(response =>
        {
            user = response;

        });
    }

    public void SignUpUserButton()
    {
        SignUpUser(emailText.text, usernameText.text, passwordText.text, passwordText1.text);
    }

    public void SignInUserButton()
    {
        SignInUser(emailText.text, passwordText.text);
    }

    private void SignUpUser(string email, string username, string password, string password1)
    {
        if (password != password1 || string.IsNullOrEmpty(password))
        {
            _errorMessage.gameObject.SetActive(true);
        }
        //else if (string.IsNullOrEmpty(email) || email.Length < 10 || email.Substring(email.Length - 11) != "@gmail.com")
                
        //{
        //    _emailErrorMessage.gameObject.SetActive(true);
        //}

        else
        {
            SceneManager.LoadScene("Message");
            string userData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true}";
            RestClient.Post<SignResponse>("https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + AuthKey, userData).Then(
                response =>
                {
                    string emailVerification = "{\"requestType\":\"VERIFY_EMAIL\",\"idToken\":\"" + response.idToken + "\", \"continueUrl\": \"" + emailActionLink + "\"}";
                    RestClient.Post(
                        "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + AuthKey,
                        emailVerification);
                    localId = response.localId;

                    PostToDatabase(true, response.idToken);
                    CheckEmailVerification(response.idToken, username);

                }).Catch(error =>
                {
                    Debug.Log(error);
                });
        }
    }


    private void SignInUser(string email, string password)
    {
        string userData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true}";
        RestClient.Post<SignResponse>("https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + AuthKey, userData).Then(
            response =>
            {
                idToken = response.idToken;
                localId = response.localId;
                GetUsername();
                SceneManager.LoadScene("Menu");

            }).Catch(error =>
            {
                Debug.Log(error);
            });
    }

    private void CheckEmailVerification(string idToken, string username)
    {
        string emailVerification = "{\"idToken\":\"" + idToken + "\"}";
        RestClient.Post(
            "https://identitytoolkit.googleapis.com/v1/accounts:lookup?key=" + AuthKey,
            emailVerification).Then(
            emailResponse =>
            {
                Debug.Log("Email verification response: " + emailResponse.Text); // Log the response

                fsData emailVerificationData = fsJsonParser.Parse(emailResponse.Text);
                EmailConfirmationInfo emailConfirmationInfo = new EmailConfirmationInfo();
                var result = serializer.TryDeserialize(emailVerificationData, ref emailConfirmationInfo);
                if (!result.Succeeded)
                {
                    Debug.LogError("Error deserializing email verification response: " + result.FormattedMessages);
                    return;
                }

                if (emailConfirmationInfo.users[0].emailVerified)
                {
                    // Proceed with further actions
                    Debug.Log("Email verification passed!");
                    // Change the scene after email verification
                    SceneManager.LoadScene("test");
                }
                else
                {
                    Debug.Log("Email verification failed or not yet completed.");
                }
            }).Catch(error =>
            {
                Debug.Log("Error during email verification: " + error); // Log the error
            });
    }


    public void ChangeSene()
    {
        SceneManager.LoadScene("Register");
    }

    public void ChangeSeneLogin()
    {
        SceneManager.LoadScene("Login");
    }

    private void GetUsername()
    {
        RestClient.Get<User>(databaseURL + "/" + localId + ".json?auth=" + idToken).Then(response =>
        {

        });
    }

    private void GetLocalId()
    {
        RestClient.Get(databaseURL + ".json?auth=" + idToken).Then(response =>
        {


            fsData userData = fsJsonParser.Parse(response.Text);
            Dictionary<string, User> users = null;
            serializer.TryDeserialize(userData, ref users);
        }).Catch(error =>
        {
            Debug.Log(error);
        });
    }
}
