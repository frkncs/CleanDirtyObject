using UnityEngine;

public class GlassController : MonoBehaviour
{
	#region Variables

	// Public Variables

	// Private Variables
	[SerializeField] private Texture[] dirtTexturesSort;
	
	private MeshRenderer _meshRenderer;

    private const string dirtMaskRef = "Texture2D_c7c1c754f575413abc9ef97eb2cc07e6";

    #endregion Variables

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _meshRenderer.material.SetTexture(dirtMaskRef, dirtTexturesSort[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _meshRenderer.material.SetTexture(dirtMaskRef, dirtTexturesSort[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _meshRenderer.material.SetTexture(dirtMaskRef, dirtTexturesSort[2]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _meshRenderer.material.SetTexture(dirtMaskRef, dirtTexturesSort[3]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _meshRenderer.material.SetTexture(dirtMaskRef, dirtTexturesSort[4]);
        }
    }
}