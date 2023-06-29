using TMPro;
using Unity.Entities;
using UnityEngine;

public class MainMenuUI : MonoBehaviour, IPlayerNameChanged
{
	public TMP_Text playerName;
	
	public void PlayerNameChanged(string newName)
	{
		Debug.Log(newName);
		playerName.text = newName;
	}

    private void Start()
    {
	    World world = World.DefaultGameObjectInjectionWorld;
        EntityManager entityManager = world.EntityManager;
        Entity entity = entityManager.CreateEntity(typeof(PlayerNameChanged));
        entityManager.AddComponentObject(entity, new PlayerNameChanged
        {
	        Listener = this
        });
    }
}