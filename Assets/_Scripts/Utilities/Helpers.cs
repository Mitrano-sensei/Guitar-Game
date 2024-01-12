using UnityEngine;

/// <summary>
/// A static class for general helpful methods
/// </summary>
public static class Helpers 
{
    /// <summary>
    /// Destroy all child objects of this transform (Unintentionally evil sounding).
    /// Use it like so:
    /// <code>
    /// transform.DestroyChildren();
    /// </code>
    /// </summary>
    public static void DestroyChildren(this Transform t) {
        foreach (Transform child in t) Object.Destroy(child.gameObject);
    }

    #region Vectors

    public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? v.x, y ?? v.y, z ?? v.z);
    }

    #endregion
}
