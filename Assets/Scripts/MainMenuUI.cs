using TMPro;
using Unity.Entities;
using UnityEngine;

public class MainMenuUI : MonoBehaviour, IPlayerNameChanged
{
	public TMP_Text playerName;
	
	public void PlayerNameChanged(string newName)
	{
		playerName.text = newName;
	}

	class Baker : Baker<MainMenuUI>
	{
		public override void Bake(MainMenuUI authoring)
		{
			var entity = GetEntity(TransformUsageFlags.None);
			AddComponentObject(entity, new PlayerNameChanged
			{
				Listener = authoring
			});
		}
	}
}