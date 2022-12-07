using System;
using System.Collections.Generic;
using UnityEngine;

//Copyright (c) 2022 khjtoy
public static class ExtensionMethods
{
    #region Transform
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
    public static void DestoryChildren(this Transform transform)
    {
        for (var i = transform.childCount - 1; i >= 0; i--)
        {
            UnityEngine.Object.Destroy(transform.GetChild(i).gameObject);
        }
    }
    public static void DisableChildren(this Transform transform)
    {
        for (var i = transform.childCount - 1; i >= 0; i--)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
    public static List<GameObject> AllChildrenObjList(this Transform transform)
    {
        List<GameObject> childObjects = new List<GameObject>();
        for (var i = 0; i < transform.childCount; i++)
        {
            childObjects.Add(transform.GetChild(i).gameObject);
        }
        return childObjects;
    }
    public static GameObject[] AllChildrenObjArray(this Transform transform)
    {
        GameObject[] childObjects = new GameObject[transform.childCount];
        for (var i = 0; i < transform.childCount; i++)
        {
            childObjects[i] = transform.GetChild(i).gameObject;
        }
        return childObjects;
    }
    public static List<Transform> AllChildrenObjListT(this Transform transform)
    {
        List<Transform> childObjects = new List<Transform>();
        for (var i = 0; i < transform.childCount; i++)
        {
            childObjects.Add(transform.GetChild(i));
        }
        return childObjects;
    }
    public static Transform[] AllChildrenObjArrayT(this Transform transform)
    {
        Transform[] childObjects = new Transform[transform.childCount];
        for (var i = 0; i < transform.childCount; i++)
        {
            childObjects[i] = transform.GetChild(i);
        }
        return childObjects;
    }
    public static void ResetPosition(this Transform transform)
    {
        transform.localPosition = Vector3.zero;
    }
    public static void SetPosition(this Transform transform, float x, float y, float z)
    {
        transform.localPosition = new Vector3(x, y, z);
    }
    public static void SetPositionX(this Transform transform, float x)
    {
        Vector3 vec = transform.localPosition;
        vec.x = x;
        transform.localPosition = vec;
    }
    public static void SetPositionY(this Transform transform, float y)
    {
        Vector3 vec = transform.localPosition;
        vec.y = y;
        transform.localPosition = vec;
    }
    public static void SetPositionZ(this Transform transform, float z)
    {
        Vector3 vec = transform.localPosition;
        vec.z = z;
        transform.localPosition = vec;
    }
    public static void AddPosition(this Transform trans, float x, float y, float z)
    {
        trans.localPosition += new Vector3(x, y, z);
    }
    public static void AddPosition(this Transform trans, Vector3 vector)
    {
        trans.localPosition += vector;
    }
    public static void AddPositionX(this Transform trans, float x)
    {
        Vector3 vec = trans.localPosition;
        vec.x += x;
        trans.localPosition = vec;
    }
    public static void AddPositionY(this Transform trans, float y)
    {
        Vector3 vec = trans.localPosition;
        vec.y += y;
        trans.localPosition = vec;
    }
    public static void AddPositionZ(this Transform trans, float z)
    {
        Vector3 vec = trans.localPosition;
        vec.z += z;
        trans.localPosition = vec;
    }
    public static void SubPosition(this Transform trans, float x, float y, float z)
    {
        trans.localPosition -= new Vector3(x, y, z);
    }
    public static void SubPosition(this Transform trans, Vector3 vector)
    {
        trans.localPosition -= vector;
    }
    public static void SubPositionX(this Transform trans, float x)
    {
        Vector3 vec = trans.localPosition;
        vec.x -= x;
        trans.localPosition = vec;
    }
    public static void SubPositionY(this Transform trans, float y)
    {
        Vector3 vec = trans.localPosition;
        vec.y -= y;
        trans.localPosition = vec;
    }
    public static void SubPositionZ(this Transform trans, float z)
    {
        Vector3 vec = trans.localPosition;
        vec.z -= z;
        trans.localPosition = vec;
    }
    public static void MulPosition(this Transform trans, float x, float y, float z = 1)
    {
        trans.localPosition = new Vector3(trans.localPosition.x * x, trans.localPosition.y * y, trans.localPosition.z * z);
    }
    public static void MulPosition(this Transform trans, Vector3 vector)
    {
        trans.localPosition = new Vector3(trans.localPosition.x * vector.x,
            trans.localPosition.y * vector.y,
            trans.localPosition.z * vector.z);
    }
    public static void MulPositionX(this Transform trans, float x)
    {
        Vector3 vec = trans.localPosition;
        vec.x *= x;
        trans.localPosition = vec;
    }
    public static void MulPositionY(this Transform trans, float y)
    {
        Vector3 vec = trans.localPosition;
        vec.y *= y;
        trans.localPosition = vec;
    }
    public static void MulPositionZ(this Transform trans, float z)
    {
        Vector3 vec = trans.localPosition;
        vec.z *= z;
        trans.localPosition = vec;
    }
    public static void DivPosition(this Transform trans, float x, float y, float z = 0)
    {
        trans.localPosition = new Vector3(trans.localPosition.x == 0 || x == 0 ? trans.localPosition.x : trans.localPosition.x / x,
                                          trans.localPosition.y == 0 || y == 0 ? trans.localPosition.y : trans.localPosition.y / y,
                                          trans.localPosition.z == 0 || z == 0 ? trans.localPosition.z : trans.localPosition.z / z);
    }
    public static void DivPosition(this Transform trans, Vector3 vector)
    {
        trans.localPosition = new Vector3(trans.localPosition.x == 0 || vector.x == 0 ? trans.localPosition.x : trans.localPosition.x / vector.x,
                                          trans.localPosition.y == 0 || vector.y == 0 ? trans.localPosition.y : trans.localPosition.y / vector.y,
                                          trans.localPosition.z == 0 || vector.z == 0 ? trans.localPosition.z : trans.localPosition.z / vector.z);
    }
    public static void DivPositionX(this Transform trans, float x)
    {
        Vector3 vec = trans.localPosition;
        vec.x /= x;
        trans.localPosition = vec;
    }
    public static void DivPositionY(this Transform trans, float y)
    {
        Vector3 vec = trans.localPosition;
        vec.y /= y;
        trans.localPosition = vec;
    }
    public static void DivPositionZ(this Transform trans, float z)
    {
        Vector3 vec = trans.localPosition;
        vec.z /= z;
        trans.localPosition = vec;
    }
    #endregion
    #region Vector
    public static Vector2 ResetVector(this Vector2 vector)
    {
        return new Vector2(0, 0);
    }
    public static Vector2Int ResetVector(this Vector2Int vector)
    {
        return new Vector2Int(0, 0);
    }
    public static Vector3 ResetVector(this Vector3 vector)
    {
        return new Vector3(0, 0, 0);
    }
    public static Vector3Int ResetVector(this Vector3Int vector)
    {
        return new Vector3Int(0, 0, 0);
    }
    public static Vector2 ChangeVector2XY(this Vector3 vector)
    {
        return new Vector2(vector.x, vector.y);
    }
    public static Vector2 ChangeVector2XY(this Vector3Int vector)
    {
        return new Vector2(vector.x, vector.y);
    }
    public static Vector2Int ChangeVector2IntXY(this Vector3 vector)
    {
        return new Vector2Int((int)vector.x, (int)vector.y);
    }
    public static Vector2Int ChangeVector2IntXY(this Vector3Int vector)
    {
        return new Vector2Int(vector.x, vector.y);
    }
    public static Vector2 ChangeVector2XZ(this Vector3 vector)
    {
        return new Vector2(vector.x, vector.z);
    }
    public static Vector2 ChangeVector2XZ(this Vector3Int vector)
    {
        return new Vector2(vector.x, vector.z);
    }
    public static Vector2Int ChangeVector2IntXZ(this Vector3 vector)
    {
        return new Vector2Int((int)vector.x, (int)vector.z);
    }
    public static Vector2Int ChangeVector2IntXZ(this Vector3Int vector)
    {
        return new Vector2Int(vector.x, vector.z);
    }
    public static Vector2 SetX(this Vector2 vector, float x)
    {
        return new Vector2(x, vector.y);
    }
    public static Vector3 SetX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }
    public static Vector2Int SetX(this Vector2Int vector, int x)
    {
        return new Vector2Int(x, vector.y);
    }
    public static Vector3Int SetX(this Vector3Int vector, int x)
    {
        return new Vector3Int(x, vector.y, vector.z);
    }
    public static Vector2 SetY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, y);
    }
    public static Vector3 SetY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y, vector.z);
    }
    public static Vector2Int SetY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, y);
    }
    public static Vector3Int SetY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, y, vector.z);
    }
    public static Vector3 SetZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z);
    }
    public static Vector3Int SetZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, z);
    }
    public static Vector2 AddX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x + x, vector.y);
    }
    public static Vector3 AddX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x + x, vector.y, vector.z);
    }
    public static Vector2Int AddX(this Vector2Int vector, int x)
    {
        return new Vector2Int(vector.x + x, vector.y);
    }
    public static Vector3Int AddX(this Vector3Int vector, int x)
    {
        return new Vector3Int(vector.x + x, vector.y, vector.z);
    }
    public static Vector2 AddY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y + y);
    }
    public static Vector3 AddY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y + y, vector.z);
    }
    public static Vector2Int AddY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, vector.y + y);
    }
    public static Vector3Int AddY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, vector.y + y, vector.z);
    }
    public static Vector3 AddZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z + z);
    }
    public static Vector3Int AddZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, vector.z + z);
    }
    public static Vector2 AddVec(this Vector2 vector, float x, float y)
    {
        return new Vector2(vector.x + x, vector.y + y);
    }
    public static Vector2 AddVec(this Vector2 vector, Vector2 offset)
    {
        return new Vector2(vector.x + offset.x, vector.y + offset.y);
    }
    public static Vector2Int AddVec(this Vector2Int vector, int x, int y)
    {
        return new Vector2Int(vector.x + x, vector.y + y);
    }
    public static Vector2Int AddVec(this Vector2Int vector, Vector2Int offset)
    {
        return new Vector2Int(vector.x + offset.x, vector.y + offset.y);
    }
    public static Vector3 AddVec(this Vector3 vector, float x, float y, float z = 0)
    {
        return new Vector3(vector.x + x, vector.y + y, vector.z + z);
    }
    public static Vector3 AddVec(this Vector3 vector, Vector3 offset)
    {
        return new Vector3(vector.x + offset.x, vector.y + offset.y, vector.z + offset.z);
    }
    public static Vector3Int AddVec(this Vector3Int vector, int x, int y, int z = 0)
    {
        return new Vector3Int(vector.x + x, vector.y + y, vector.z + z);
    }
    public static Vector3Int AddVec(this Vector3Int vector, Vector3Int offset)
    {
        return new Vector3Int(vector.x + offset.x, vector.y + offset.y, vector.z + offset.z);
    }
    public static Vector2 SubX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x - x, vector.y);
    }
    public static Vector3 SubX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x - x, vector.y, vector.z);
    }
    public static Vector2Int SubX(this Vector2Int vector, int x)
    {
        return new Vector2Int(vector.x - x, vector.y);
    }
    public static Vector3Int SubX(this Vector3Int vector, int x)
    {
        return new Vector3Int(vector.x - x, vector.y, vector.z);
    }
    public static Vector2 SubY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y - y);
    }
    public static Vector3 SubY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y - y, vector.z);
    }
    public static Vector2Int SubY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, vector.y - y);
    }
    public static Vector3Int SubY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, vector.y - y, vector.z);
    }
    public static Vector3 SubZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z - z);
    }
    public static Vector3Int SubZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, vector.z - z);
    }
    public static Vector2 SubVec(this Vector2 vector, float x, float y)
    {
        return new Vector2(vector.x - x, vector.y - y);
    }
    public static Vector2 SubVec(this Vector2 vector, Vector2 offset)
    {
        return new Vector2(vector.x - offset.x, vector.y - offset.y);
    }
    public static Vector2Int SubVec(this Vector2Int vector, int x, int y)
    {
        return new Vector2Int(vector.x - x, vector.y - y);
    }
    public static Vector2Int SubVec(this Vector2Int vector, Vector2Int offset)
    {
        return new Vector2Int(vector.x - offset.x, vector.y - offset.y);
    }
    public static Vector3 SubVec(this Vector3 vector, float x, float y, float z = 0)
    {
        return new Vector3(vector.x - x, vector.y - y, vector.z - z);
    }
    public static Vector3 SubVec(this Vector3 vector, Vector3 offset)
    {
        return new Vector3(vector.x - offset.x, vector.y - offset.y, vector.z - offset.z);
    }
    public static Vector3Int SubVec(this Vector3Int vector, int x, int y, int z = 0)
    {
        return new Vector3Int(vector.x - x, vector.y - y, vector.z - z);
    }
    public static Vector3Int SubVec(this Vector3Int vector, Vector3Int offset)
    {
        return new Vector3Int(vector.x - offset.x, vector.y - offset.y, vector.z - offset.z);
    }
    public static Vector2 MulX(this Vector2 vector, float x)
    {
        return new Vector2(vector.x * x, vector.y);
    }
    public static Vector3 MulX(this Vector3 vector, float x)
    {
        return new Vector3(vector.x * x, vector.y, vector.z);
    }
    public static Vector2Int MulX(this Vector2Int vector, int x)
    {
        return new Vector2Int(vector.x * x, vector.y);
    }
    public static Vector3Int MulX(this Vector3Int vector, int x)
    {
        return new Vector3Int(vector.x * x, vector.y, vector.z);
    }
    public static Vector2 MulY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, vector.y * y);
    }
    public static Vector3 MulY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, vector.y * y, vector.z);
    }
    public static Vector2Int MulY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, vector.y * y);
    }
    public static Vector3Int MulY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, vector.y * y, vector.z);
    }
    public static Vector3 MulZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, vector.z * z);
    }
    public static Vector3Int MulZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, vector.z * z);
    }
    public static Vector2 MulVec(this Vector2 vector, float x, float y)
    {
        return new Vector2(vector.x * x, vector.y * y);
    }
    public static Vector2 MulVec(this Vector2 vector, Vector2 offset)
    {
        return new Vector2(vector.x * offset.x, vector.y * offset.y);
    }
    public static Vector2Int MulVec(this Vector2Int vector, int x, int y)
    {
        return new Vector2Int(vector.x * x, vector.y * y);
    }
    public static Vector2Int MulVec(this Vector2Int vector, Vector2Int offset)
    {
        return new Vector2Int(vector.x * offset.x, vector.y * offset.y);
    }
    public static Vector3 MulVec(this Vector3 vector, float x, float y, float z = 0)
    {
        return new Vector3(vector.x * x, vector.y * y, vector.z * z);
    }
    public static Vector3 MulVec(this Vector3 vector, Vector3 offset)
    {
        return new Vector3(vector.x * offset.x, vector.y * offset.y, vector.z * offset.z);
    }
    public static Vector3Int MulVec(this Vector3Int vector, int x, int y, int z = 0)
    {
        return new Vector3Int(vector.x * x, vector.y * y, vector.z * z);
    }
    public static Vector3Int MulVec(this Vector3Int vector, Vector3Int offset)
    {
        return new Vector3Int(vector.x * offset.x, vector.y * offset.y, vector.z * offset.z);
    }
    public static Vector2 DivX(this Vector2 vector, float x)
    {
        return new Vector2(x == 0 || vector.x == 0 ? vector.x : vector.x / x, vector.y);
    }
    public static Vector3 DivX(this Vector3 vector, float x)
    {
        return new Vector3(x == 0 || vector.x == 0 ? vector.x : vector.x / x, vector.y, vector.z);
    }
    public static Vector2Int DivX(this Vector2Int vector, int x)
    {
        return new Vector2Int(x == 0 || vector.x == 0 ? vector.x : vector.x / x, vector.y);
    }
    public static Vector3Int DivX(this Vector3Int vector, int x)
    {
        return new Vector3Int(x == 0 || vector.x == 0 ? vector.x : vector.x / x, vector.y, vector.z);
    }
    public static Vector2 DivY(this Vector2 vector, float y)
    {
        return new Vector2(vector.x, y == 0 || vector.y == 0 ? vector.y : vector.y / y);
    }
    public static Vector3 DivY(this Vector3 vector, float y)
    {
        return new Vector3(vector.x, y == 0 || vector.y == 0 ? vector.y : vector.y / y, vector.z);
    }
    public static Vector2Int DivY(this Vector2Int vector, int y)
    {
        return new Vector2Int(vector.x, y == 0 || vector.y == 0 ? vector.y : vector.y / y);
    }
    public static Vector3Int DivY(this Vector3Int vector, int y)
    {
        return new Vector3Int(vector.x, y == 0 || vector.y == 0 ? vector.y : vector.y / y, vector.z);
    }
    public static Vector3 DivZ(this Vector3 vector, float z)
    {
        return new Vector3(vector.x, vector.y, z == 0 || vector.z == 0 ? vector.z : vector.z / z);
    }
    public static Vector3Int DivZ(this Vector3Int vector, int z)
    {
        return new Vector3Int(vector.x, vector.y, z == 0 || vector.z == 0 ? vector.z : vector.z / z);
    }
    public static Vector2 DivVec(this Vector2 vector, float x, float y)
    {
        return new Vector2(x == 0 || vector.x == 0 ? vector.x : vector.x / x,
                           y == 0 || vector.y == 0 ? vector.y : vector.y / y);
    }
    public static Vector2 DivVec(this Vector2 vector, Vector2 offset)
    {
        return new Vector2(vector.x == 0 || offset.x == 0 ? vector.x : vector.x / offset.x,
                           vector.y == 0 || offset.y == 0 ? vector.y : vector.y / offset.y);
    }
    public static Vector2Int DivVec(this Vector2Int vector, int x, int y)
    {
        return new Vector2Int(x == 0 || vector.x == 0 ? vector.x : vector.x / x,
                           y == 0 || vector.y == 0 ? vector.y : vector.y / y);
    }
    public static Vector2Int DivVec(this Vector2Int vector, Vector2Int offset)
    {
        return new Vector2Int(vector.x == 0 || offset.x == 0 ? vector.x : vector.x / offset.x,
                           vector.y == 0 || offset.y == 0 ? vector.y : vector.y / offset.y);
    }
    public static Vector3 DivVec(this Vector3 vector, float x, float y, float z = 0)
    {
        return new Vector3(x == 0 || vector.x == 0 ? vector.x : vector.x / x,
                           y == 0 || vector.y == 0 ? vector.y : vector.y / y,
                           z == 0 || vector.z == 0 ? vector.z : vector.z / z);
    }
    public static Vector3 DivVec(this Vector3 vector, Vector3 offset)
    {
        return new Vector3(vector.x == 0 || offset.x == 0 ? vector.x : vector.x / offset.x,
                           vector.y == 0 || offset.y == 0 ? vector.y : vector.y / offset.y,
                           vector.z == 0 || offset.z == 0 ? vector.z : vector.z / offset.z);
    }
    public static Vector3Int DivVec(this Vector3Int vector, int x, int y, int z = 0)
    {
        return new Vector3Int(x == 0 || vector.x == 0 ? vector.x : vector.x / x,
                           y == 0 || vector.y == 0 ? vector.y : vector.y / y,
                           z == 0 || vector.z == 0 ? vector.z : vector.z / z);
    }
    public static Vector3Int DivVec(this Vector3Int vector, Vector3Int offset)
    {
        return new Vector3Int(vector.x == 0 || offset.x == 0 ? vector.x : vector.x / offset.x,
                           vector.y == 0 || offset.y == 0 ? vector.y : vector.y / offset.y,
                           vector.z == 0 || offset.z == 0 ? vector.z : vector.z / offset.z);
    }
    public static Vector3 Flattened(this Vector3 vector)
    {
        return new Vector3(vector.x, 0f, vector.z);
    }
    public static Vector3 Flattened(this Vector2 vector)
    {
        return new Vector3(vector.x, 0f, vector.y);
    }
    public static Vector3Int Flattened(this Vector3Int vector)
    {
        return new Vector3Int(vector.x, 0, vector.z);
    }
    public static float DistanceFlat(this Vector3 origin, Vector3 destination)
    {
        return Vector3.Distance(origin.Flattened(), destination.Flattened());
    }
    public static float DistanceFlat(this Vector3Int origin, Vector3Int destination)
    {
        return Vector3Int.Distance(origin.Flattened(), destination.Flattened());
    }
    public static Vector2 GetMinDistance(this Vector2 vector, Vector2[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = Vector2.Distance(vector, otherVectors[0]);
        Vector2 minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = Vector2.Distance(vector, otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    public static Vector2Int GetMinDistance(this Vector2Int vector, Vector2Int[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = Vector2Int.Distance(vector, otherVectors[0]);
        Vector2Int minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = Vector2Int.Distance(vector, otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    public static Vector3 GetMinDistance(this Vector3 vector, Vector3[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = Vector3.Distance(vector, otherVectors[0]);
        Vector3 minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = Vector3.Distance(vector, otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    public static Vector3 GetMinDistanceFlat(this Vector3 vector, Vector3[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = vector.DistanceFlat(otherVectors[0]);
        Vector3 minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = vector.DistanceFlat(otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    public static Vector3Int GetMinDistance(this Vector3Int vector, Vector3Int[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = Vector3Int.Distance(vector, otherVectors[0]);
        Vector3Int minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = Vector3Int.Distance(vector, otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    public static Vector3Int GetMinDistanceFlat(this Vector3Int vector, Vector3Int[] otherVectors)
    {
        if (otherVectors.Length == 0) throw new Exception("The list of other vectors is empty");
        float minDistance = vector.DistanceFlat(otherVectors[0]);
        Vector3Int minVector = otherVectors[0];
        for (int i = otherVectors.Length - 1; i > 0; i--)
        {
            var newDistance = vector.DistanceFlat(otherVectors[i]);
            if (newDistance < minDistance)
            {
                minDistance = newDistance;
                minVector = otherVectors[i];
            }
        }
        return minVector;
    }
    #endregion
    #region GameObject
    public static T GetOrAddComponent<T>(this GameObject gameObject, bool flagAdd = true) where T : UnityEngine.Component
    {
        T component = gameObject.GetComponent<T>();
        if (component == null)
        {
            gameObject.AddComponent<T>();
            if (!flagAdd)
            {
                Debug.LogError($"This {typeof(T).ToString()} Added.");
            }
        }
        return component;
    }
    public static bool HasComponent<T>(this GameObject gameObject) where T : UnityEngine.Component
    {
        return gameObject.GetComponent<T>() != null;
    }
    #endregion
    #region List
    public static T GetRandomItem<T>(this List<T> list)
    {
        return list[UnityEngine.Random.Range(0, list.Count)];
    }
    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = list.Count - 1; i > 1; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            T temp = list[j];
            list[j] = list[i];
            list[i] = temp;
        }
    }
    #endregion
    #region Rigidbody
    public static void ChangeDirection(this Rigidbody rb, Vector3 direction)
    {
        rb.velocity = direction.normalized * rb.velocity.magnitude;
    }
    public static void ChangeDirection(this Rigidbody2D rb, Vector2 direction)
    {
        rb.velocity = direction.normalized * rb.velocity.magnitude;
    }
    public static void Normalizeveloctiy(this Rigidbody rb, float magnitude = 1)
    {
        rb.velocity = rb.velocity.normalized * magnitude;
    }
    public static void Normalizeveloctiy(this Rigidbody2D rb, float magnitude = 1)
    {
        rb.velocity = rb.velocity.normalized * magnitude;
    }
    #endregion
    #region Array
    public static T GetRandomItem<T>(this T[] list)
    {
        return list[UnityEngine.Random.Range(0, list.Length)];
    }
    public static void Shuffle<T>(this T[] array)
    {
        for (int i = array.Length - 1; i > 1; i--)
        {
            int j = UnityEngine.Random.Range(0, i + 1);
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
    #endregion
}