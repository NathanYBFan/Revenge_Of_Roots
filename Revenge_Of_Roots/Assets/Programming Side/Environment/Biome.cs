using UnityEngine;
using UnityEngine.Tilemaps;

//This class autotiles grass and tints it based on a perlin noise value mapped onto a colormap.
//This script should either be attached to a tilemap or be rewritten to include a tilemap reference.
public class Biome : MonoBehaviour
{
    public int pixWidth;
    public int pixHeight;

    // The origin of the sampled area in the plane.
    public float xOrg;
    public float yOrg;


    // The number of cycles of the basic noise pattern that are repeated
    // over the width and height of the texture.
    public float scale = 1.0F;

    public Texture2D gradMap; //Gradient colormap for biome shifting
    public Grid grid;         //Reference to the grid of which this tilemap is a child of
    public Tile grass;        //The tile we want to autotile. For this instance, it's grass
    public Vector3Int gridBottomLeft;//The bottom left corner of the viewport, but mapped to the cell grid of the tilemap.
    public Vector3Int gridTopRight;//The top right corner of the viewport, but mapped to the cell grid of the tilemap.
    //public GameObject mask;   //Reference to a SpriteMask
    public int seed;          //Seed value for "custom noise maps"
    public GameObject player; //Reference to the player
    public int noiseValue;    //The noise value (but mapped to a 0 - 255 range)
    Vector3 size;             //The vector 3 scale of the entire viewport (viewable range)
    void Start()
    {
        size = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane)) - Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        //mask.transform.localScale = size;   
        GenerateTerrain();
    }

    
    void CalcNoise(int x, int y)
    {
        float sample = Mathf.PerlinNoise((x + seed)/ scale, (y + seed)/ scale); //First sampling of noise.
        float sample2 = Mathf.PerlinNoise(x / scale, y / scale);                //Second sampling of noise.
        noiseValue = Mathf.FloorToInt(sample * gradMap.width - 1);           

        Vector3Int gridPos = grid.WorldToCell(new Vector3(x, y, 0)); //The grid position of this point. Probably could just do "new Vector3Int(x, y, 0)" but I didn't try that yet lol.

        //This long mf line is mapping rgb to a pixel on the colourmap. Yertle flashbacks.
        Color thisColor = new Color(gradMap.GetPixel(Mathf.FloorToInt(sample2 * gradMap.width - 1), (Mathf.FloorToInt(sample2 * gradMap.width - 1))).r, gradMap.GetPixel(Mathf.FloorToInt(sample2 * gradMap.width - 1), (Mathf.FloorToInt(sample2 * gradMap.width - 1))).g, gradMap.GetPixel(Mathf.FloorToInt(sample2 * gradMap.width - 1), (Mathf.FloorToInt(sample2 * gradMap.width - 1))).b);
        
        //You have to set the tile's flags to none before editing colours or else it won't work.
        GetComponent<Tilemap>().SetTileFlags(gridPos, TileFlags.None);
        GetComponent<Tilemap>().SetColor(gridPos, thisColor);
        
    }
    void GenerateTerrain()
    {
        gridBottomLeft = grid.WorldToCell(Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane)));
        gridTopRight = grid.WorldToCell(Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane)));

        for (int y = gridBottomLeft.y; y <= gridTopRight.y; y++)
        {
            for (int x = gridBottomLeft.x; x <= gridTopRight.x; x++)
            {
                //Grabbing the tile map and setting the tile at x, y to be grass.
                //DO NOTE: TileMap positions work in Vector3Int which DOES make a difference (Vector3 doesn't work).
                GetComponent<Tilemap>().SetTile(new Vector3Int(x, y, 0), grass);

                //Calculate the noise colour value at this position.
                //CalcNoise(x, y);
            }
        }
    }
    void UnloadTiles()
    {
        
        

    }
    void Update()
    {
        GenerateTerrain();
    }
}
