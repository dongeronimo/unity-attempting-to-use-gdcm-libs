#----------------------------------------------------------------
# Generated CMake target import file.
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "gdcmjpeg8" for configuration ""
set_property(TARGET gdcmjpeg8 APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmjpeg8 PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmjpeg8.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmjpeg8 )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmjpeg8 "${_IMPORT_PREFIX}/lib/libgdcmjpeg8.so" )

# Import target "gdcmjpeg12" for configuration ""
set_property(TARGET gdcmjpeg12 APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmjpeg12 PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmjpeg12.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmjpeg12 )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmjpeg12 "${_IMPORT_PREFIX}/lib/libgdcmjpeg12.so" )

# Import target "gdcmjpeg16" for configuration ""
set_property(TARGET gdcmjpeg16 APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmjpeg16 PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmjpeg16.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmjpeg16 )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmjpeg16 "${_IMPORT_PREFIX}/lib/libgdcmjpeg16.so" )

# Import target "gdcmexpat" for configuration ""
set_property(TARGET gdcmexpat APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmexpat PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmexpat.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmexpat )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmexpat "${_IMPORT_PREFIX}/lib/libgdcmexpat.so" )

# Import target "gdcmopenjp2" for configuration ""
set_property(TARGET gdcmopenjp2 APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmopenjp2 PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmopenjp2.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmopenjp2 )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmopenjp2 "${_IMPORT_PREFIX}/lib/libgdcmopenjp2.so" )

# Import target "gdcmcharls" for configuration ""
set_property(TARGET gdcmcharls APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmcharls PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmcharls.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmcharls )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmcharls "${_IMPORT_PREFIX}/lib/libgdcmcharls.so" )

# Import target "gdcmzlib" for configuration ""
set_property(TARGET gdcmzlib APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmzlib PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmzlib.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmzlib )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmzlib "${_IMPORT_PREFIX}/lib/libgdcmzlib.so" )

# Import target "gdcmuuid" for configuration ""
set_property(TARGET gdcmuuid APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmuuid PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmuuid.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmuuid )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmuuid "${_IMPORT_PREFIX}/lib/libgdcmuuid.so" )

# Import target "socketxx" for configuration ""
set_property(TARGET socketxx APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(socketxx PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libsocketxx.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS socketxx )
list(APPEND _IMPORT_CHECK_FILES_FOR_socketxx "${_IMPORT_PREFIX}/lib/libsocketxx.so" )

# Import target "gdcmCommon" for configuration ""
set_property(TARGET gdcmCommon APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmCommon PROPERTIES
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmCommon.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmCommon )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmCommon "${_IMPORT_PREFIX}/lib/libgdcmCommon.so" )

# Import target "gdcmDICT" for configuration ""
set_property(TARGET gdcmDICT APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmDICT PROPERTIES
  IMPORTED_LINK_DEPENDENT_LIBRARIES_NOCONFIG "gdcmDSED;gdcmIOD"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmDICT.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmDICT )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmDICT "${_IMPORT_PREFIX}/lib/libgdcmDICT.so" )

# Import target "gdcmDSED" for configuration ""
set_property(TARGET gdcmDSED APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmDSED PROPERTIES
  IMPORTED_LINK_DEPENDENT_LIBRARIES_NOCONFIG "gdcmzlib"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmDSED.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmDSED )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmDSED "${_IMPORT_PREFIX}/lib/libgdcmDSED.so" )

# Import target "gdcmIOD" for configuration ""
set_property(TARGET gdcmIOD APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmIOD PROPERTIES
  IMPORTED_LINK_DEPENDENT_LIBRARIES_NOCONFIG "gdcmexpat"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmIOD.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmIOD )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmIOD "${_IMPORT_PREFIX}/lib/libgdcmIOD.so" )

# Import target "gdcmMSFF" for configuration ""
set_property(TARGET gdcmMSFF APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmMSFF PROPERTIES
  IMPORTED_LINK_DEPENDENT_LIBRARIES_NOCONFIG "gdcmjpeg8;gdcmjpeg12;gdcmjpeg16;gdcmopenjp2;gdcmcharls;gdcmuuid"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmMSFF.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmMSFF )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmMSFF "${_IMPORT_PREFIX}/lib/libgdcmMSFF.so" )

# Import target "gdcmMEXD" for configuration ""
set_property(TARGET gdcmMEXD APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(gdcmMEXD PROPERTIES
  IMPORTED_LINK_DEPENDENT_LIBRARIES_NOCONFIG "gdcmMSFF;gdcmDICT;gdcmDSED;gdcmIOD;socketxx"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/libgdcmMEXD.so"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS gdcmMEXD )
list(APPEND _IMPORT_CHECK_FILES_FOR_gdcmMEXD "${_IMPORT_PREFIX}/lib/libgdcmMEXD.so" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
