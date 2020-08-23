using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
    public static readonly gdcm.Tag PatientName = new gdcm.Tag(0x0010, 0x0010);
    public static readonly gdcm.Tag StudyInstanceUID = new gdcm.Tag(0x0020, 0x000d);
    public static readonly gdcm.Tag SeriesInstanceUID = new gdcm.Tag(0x0020, 0x000e);
    public static readonly gdcm.Tag DirectionCosines = new gdcm.Tag(0x0020, 0x0037);
    public static readonly gdcm.Tag ImagePosition = new gdcm.Tag(0x0020, 0x0032);
}
