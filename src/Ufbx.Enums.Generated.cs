// Generated by Hebron at 8/29/2023 7:59:25 AM

using System;
using System.Runtime.InteropServices;

namespace UfbxSharp
{
	unsafe partial class Ufbx
	{
		public enum ufbx_rotation_order
		{
			UFBX_ROTATION_ORDER_XYZ,
			UFBX_ROTATION_ORDER_XZY,
			UFBX_ROTATION_ORDER_YZX,
			UFBX_ROTATION_ORDER_YXZ,
			UFBX_ROTATION_ORDER_ZXY,
			UFBX_ROTATION_ORDER_ZYX,
			UFBX_ROTATION_ORDER_SPHERIC,
			UFBX_ROTATION_ORDER_FORCE_32BIT = 2147483647
		}
		public enum ufbx_dom_value_type
		{
			UFBX_DOM_VALUE_NUMBER,
			UFBX_DOM_VALUE_STRING,
			UFBX_DOM_VALUE_ARRAY_I8,
			UFBX_DOM_VALUE_ARRAY_I32,
			UFBX_DOM_VALUE_ARRAY_I64,
			UFBX_DOM_VALUE_ARRAY_F32,
			UFBX_DOM_VALUE_ARRAY_F64,
			UFBX_DOM_VALUE_ARRAY_RAW_STRING,
			UFBX_DOM_VALUE_ARRAY_IGNORED,
			UFBX_DOM_VALUE_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_prop_type
		{
			UFBX_PROP_UNKNOWN,
			UFBX_PROP_BOOLEAN,
			UFBX_PROP_INTEGER,
			UFBX_PROP_NUMBER,
			UFBX_PROP_VECTOR,
			UFBX_PROP_COLOR,
			UFBX_PROP_COLOR_WITH_ALPHA,
			UFBX_PROP_STRING,
			UFBX_PROP_DATE_TIME,
			UFBX_PROP_TRANSLATION,
			UFBX_PROP_ROTATION,
			UFBX_PROP_SCALING,
			UFBX_PROP_DISTANCE,
			UFBX_PROP_COMPOUND,
			UFBX_PROP_BLOB,
			UFBX_PROP_REFERENCE,
			UFBX_PROP_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_prop_flags
		{
			UFBX_PROP_FLAG_ANIMATABLE = 1,
			UFBX_PROP_FLAG_USER_DEFINED = 2,
			UFBX_PROP_FLAG_HIDDEN = 4,
			UFBX_PROP_FLAG_LOCK_X = 16,
			UFBX_PROP_FLAG_LOCK_Y = 32,
			UFBX_PROP_FLAG_LOCK_Z = 64,
			UFBX_PROP_FLAG_LOCK_W = 128,
			UFBX_PROP_FLAG_MUTE_X = 256,
			UFBX_PROP_FLAG_MUTE_Y = 512,
			UFBX_PROP_FLAG_MUTE_Z = 1024,
			UFBX_PROP_FLAG_MUTE_W = 2048,
			UFBX_PROP_FLAG_SYNTHETIC = 4096,
			UFBX_PROP_FLAG_ANIMATED = 8192,
			UFBX_PROP_FLAG_NOT_FOUND = 16384,
			UFBX_PROP_FLAG_CONNECTED = 32768,
			UFBX_PROP_FLAG_NO_VALUE = 65536,
			UFBX_PROP_FLAG_OVERRIDDEN = 131072,
			UFBX_PROP_FLAG_VALUE_REAL = 1048576,
			UFBX_PROP_FLAG_VALUE_VEC2 = 2097152,
			UFBX_PROP_FLAG_VALUE_VEC3 = 4194304,
			UFBX_PROP_FLAG_VALUE_VEC4 = 8388608,
			UFBX_PROP_FLAG_VALUE_INT = 16777216,
			UFBX_PROP_FLAG_VALUE_STR = 33554432,
			UFBX_PROP_FLAG_VALUE_BLOB = 67108864,
			UFBX_PROP_FLAGS_FORCE_32BIT = 2147483647
		}
		public enum ufbx_element_type
		{
			UFBX_ELEMENT_UNKNOWN,
			UFBX_ELEMENT_NODE,
			UFBX_ELEMENT_MESH,
			UFBX_ELEMENT_LIGHT,
			UFBX_ELEMENT_CAMERA,
			UFBX_ELEMENT_BONE,
			UFBX_ELEMENT_EMPTY,
			UFBX_ELEMENT_LINE_CURVE,
			UFBX_ELEMENT_NURBS_CURVE,
			UFBX_ELEMENT_NURBS_SURFACE,
			UFBX_ELEMENT_NURBS_TRIM_SURFACE,
			UFBX_ELEMENT_NURBS_TRIM_BOUNDARY,
			UFBX_ELEMENT_PROCEDURAL_GEOMETRY,
			UFBX_ELEMENT_STEREO_CAMERA,
			UFBX_ELEMENT_CAMERA_SWITCHER,
			UFBX_ELEMENT_MARKER,
			UFBX_ELEMENT_LOD_GROUP,
			UFBX_ELEMENT_SKIN_DEFORMER,
			UFBX_ELEMENT_SKIN_CLUSTER,
			UFBX_ELEMENT_BLEND_DEFORMER,
			UFBX_ELEMENT_BLEND_CHANNEL,
			UFBX_ELEMENT_BLEND_SHAPE,
			UFBX_ELEMENT_CACHE_DEFORMER,
			UFBX_ELEMENT_CACHE_FILE,
			UFBX_ELEMENT_MATERIAL,
			UFBX_ELEMENT_TEXTURE,
			UFBX_ELEMENT_VIDEO,
			UFBX_ELEMENT_SHADER,
			UFBX_ELEMENT_SHADER_BINDING,
			UFBX_ELEMENT_ANIM_STACK,
			UFBX_ELEMENT_ANIM_LAYER,
			UFBX_ELEMENT_ANIM_VALUE,
			UFBX_ELEMENT_ANIM_CURVE,
			UFBX_ELEMENT_DISPLAY_LAYER,
			UFBX_ELEMENT_SELECTION_SET,
			UFBX_ELEMENT_SELECTION_NODE,
			UFBX_ELEMENT_CHARACTER,
			UFBX_ELEMENT_CONSTRAINT,
			UFBX_ELEMENT_POSE,
			UFBX_ELEMENT_METADATA_OBJECT,
			UFBX_ELEMENT_TYPE_FIRST_ATTRIB = 0,
			UFBX_ELEMENT_TYPE_LAST_ATTRIB = 0,
			UFBX_ELEMENT_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_inherit_type
		{
			UFBX_INHERIT_NO_SHEAR,
			UFBX_INHERIT_NORMAL,
			UFBX_INHERIT_NO_SCALE,
			UFBX_INHERIT_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_subdivision_display_mode
		{
			UFBX_SUBDIVISION_DISPLAY_DISABLED,
			UFBX_SUBDIVISION_DISPLAY_HULL,
			UFBX_SUBDIVISION_DISPLAY_HULL_AND_SMOOTH,
			UFBX_SUBDIVISION_DISPLAY_SMOOTH,
			UFBX_SUBDIVISION_DISPLAY_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_subdivision_boundary
		{
			UFBX_SUBDIVISION_BOUNDARY_DEFAULT,
			UFBX_SUBDIVISION_BOUNDARY_LEGACY,
			UFBX_SUBDIVISION_BOUNDARY_SHARP_CORNERS,
			UFBX_SUBDIVISION_BOUNDARY_SHARP_NONE,
			UFBX_SUBDIVISION_BOUNDARY_SHARP_BOUNDARY,
			UFBX_SUBDIVISION_BOUNDARY_SHARP_INTERIOR,
			UFBX_SUBDIVISION_BOUNDARY_FORCE_32BIT = 2147483647
		}
		public enum ufbx_light_type
		{
			UFBX_LIGHT_POINT,
			UFBX_LIGHT_DIRECTIONAL,
			UFBX_LIGHT_SPOT,
			UFBX_LIGHT_AREA,
			UFBX_LIGHT_VOLUME,
			UFBX_LIGHT_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_light_decay
		{
			UFBX_LIGHT_DECAY_NONE,
			UFBX_LIGHT_DECAY_LINEAR,
			UFBX_LIGHT_DECAY_QUADRATIC,
			UFBX_LIGHT_DECAY_CUBIC,
			UFBX_LIGHT_DECAY_FORCE_32BIT = 2147483647
		}
		public enum ufbx_light_area_shape
		{
			UFBX_LIGHT_AREA_SHAPE_RECTANGLE,
			UFBX_LIGHT_AREA_SHAPE_SPHERE,
			UFBX_LIGHT_AREA_SHAPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_projection_mode
		{
			UFBX_PROJECTION_MODE_PERSPECTIVE,
			UFBX_PROJECTION_MODE_ORTHOGRAPHIC,
			UFBX_PROJECTION_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_aspect_mode
		{
			UFBX_ASPECT_MODE_WINDOW_SIZE,
			UFBX_ASPECT_MODE_FIXED_RATIO,
			UFBX_ASPECT_MODE_FIXED_RESOLUTION,
			UFBX_ASPECT_MODE_FIXED_WIDTH,
			UFBX_ASPECT_MODE_FIXED_HEIGHT,
			UFBX_ASPECT_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_aperture_mode
		{
			UFBX_APERTURE_MODE_HORIZONTAL_AND_VERTICAL,
			UFBX_APERTURE_MODE_HORIZONTAL,
			UFBX_APERTURE_MODE_VERTICAL,
			UFBX_APERTURE_MODE_FOCAL_LENGTH,
			UFBX_APERTURE_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_gate_fit
		{
			UFBX_GATE_FIT_NONE,
			UFBX_GATE_FIT_VERTICAL,
			UFBX_GATE_FIT_HORIZONTAL,
			UFBX_GATE_FIT_FILL,
			UFBX_GATE_FIT_OVERSCAN,
			UFBX_GATE_FIT_STRETCH,
			UFBX_GATE_FIT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_aperture_format
		{
			UFBX_APERTURE_FORMAT_CUSTOM,
			UFBX_APERTURE_FORMAT_16MM_THEATRICAL,
			UFBX_APERTURE_FORMAT_SUPER_16MM,
			UFBX_APERTURE_FORMAT_35MM_ACADEMY,
			UFBX_APERTURE_FORMAT_35MM_TV_PROJECTION,
			UFBX_APERTURE_FORMAT_35MM_FULL_APERTURE,
			UFBX_APERTURE_FORMAT_35MM_185_PROJECTION,
			UFBX_APERTURE_FORMAT_35MM_ANAMORPHIC,
			UFBX_APERTURE_FORMAT_70MM_PROJECTION,
			UFBX_APERTURE_FORMAT_VISTAVISION,
			UFBX_APERTURE_FORMAT_DYNAVISION,
			UFBX_APERTURE_FORMAT_IMAX,
			UFBX_APERTURE_FORMAT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_coordinate_axis
		{
			UFBX_COORDINATE_AXIS_POSITIVE_X,
			UFBX_COORDINATE_AXIS_NEGATIVE_X,
			UFBX_COORDINATE_AXIS_POSITIVE_Y,
			UFBX_COORDINATE_AXIS_NEGATIVE_Y,
			UFBX_COORDINATE_AXIS_POSITIVE_Z,
			UFBX_COORDINATE_AXIS_NEGATIVE_Z,
			UFBX_COORDINATE_AXIS_UNKNOWN,
			UFBX_COORDINATE_AXIS_FORCE_32BIT = 2147483647
		}
		public enum ufbx_nurbs_topology
		{
			UFBX_NURBS_TOPOLOGY_OPEN,
			UFBX_NURBS_TOPOLOGY_PERIODIC,
			UFBX_NURBS_TOPOLOGY_CLOSED,
			UFBX_NURBS_TOPOLOGY_FORCE_32BIT = 2147483647
		}
		public enum ufbx_marker_type
		{
			UFBX_MARKER_UNKNOWN,
			UFBX_MARKER_FK_EFFECTOR,
			UFBX_MARKER_IK_EFFECTOR,
			UFBX_MARKER_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_lod_display
		{
			UFBX_LOD_DISPLAY_USE_LOD,
			UFBX_LOD_DISPLAY_SHOW,
			UFBX_LOD_DISPLAY_HIDE,
			UFBX_LOD_DISPLAY_FORCE_32BIT = 2147483647
		}
		public enum ufbx_skinning_method
		{
			UFBX_SKINNING_METHOD_LINEAR,
			UFBX_SKINNING_METHOD_RIGID,
			UFBX_SKINNING_METHOD_DUAL_QUATERNION,
			UFBX_SKINNING_METHOD_BLENDED_DQ_LINEAR,
			UFBX_SKINNING_METHOD_FORCE_32BIT = 2147483647
		}
		public enum ufbx_cache_file_format
		{
			UFBX_CACHE_FILE_FORMAT_UNKNOWN,
			UFBX_CACHE_FILE_FORMAT_PC2,
			UFBX_CACHE_FILE_FORMAT_MC,
			UFBX_CACHE_FILE_FORMAT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_cache_data_format
		{
			UFBX_CACHE_DATA_FORMAT_UNKNOWN,
			UFBX_CACHE_DATA_FORMAT_REAL_FLOAT,
			UFBX_CACHE_DATA_FORMAT_VEC3_FLOAT,
			UFBX_CACHE_DATA_FORMAT_REAL_DOUBLE,
			UFBX_CACHE_DATA_FORMAT_VEC3_DOUBLE,
			UFBX_CACHE_DATA_FORMAT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_cache_data_encoding
		{
			UFBX_CACHE_DATA_ENCODING_UNKNOWN,
			UFBX_CACHE_DATA_ENCODING_LITTLE_ENDIAN,
			UFBX_CACHE_DATA_ENCODING_BIG_ENDIAN,
			UFBX_CACHE_DATA_ENCODING_FORCE_32BIT = 2147483647
		}
		public enum ufbx_cache_interpretation
		{
			UFBX_CACHE_INTERPRETATION_UNKNOWN,
			UFBX_CACHE_INTERPRETATION_POINTS,
			UFBX_CACHE_INTERPRETATION_VERTEX_POSITION,
			UFBX_CACHE_INTERPRETATION_VERTEX_NORMAL,
			UFBX_CACHE_INTERPRETATION_FORCE_32BIT = 2147483647
		}
		public enum ufbx_shader_type
		{
			UFBX_SHADER_UNKNOWN,
			UFBX_SHADER_FBX_LAMBERT,
			UFBX_SHADER_FBX_PHONG,
			UFBX_SHADER_OSL_STANDARD_SURFACE,
			UFBX_SHADER_ARNOLD_STANDARD_SURFACE,
			UFBX_SHADER_3DS_MAX_PHYSICAL_MATERIAL,
			UFBX_SHADER_3DS_MAX_PBR_METAL_ROUGH,
			UFBX_SHADER_3DS_MAX_PBR_SPEC_GLOSS,
			UFBX_SHADER_GLTF_MATERIAL,
			UFBX_SHADER_SHADERFX_GRAPH,
			UFBX_SHADER_BLENDER_PHONG,
			UFBX_SHADER_WAVEFRONT_MTL,
			UFBX_SHADER_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_material_fbx_map
		{
			UFBX_MATERIAL_FBX_DIFFUSE_FACTOR,
			UFBX_MATERIAL_FBX_DIFFUSE_COLOR,
			UFBX_MATERIAL_FBX_SPECULAR_FACTOR,
			UFBX_MATERIAL_FBX_SPECULAR_COLOR,
			UFBX_MATERIAL_FBX_SPECULAR_EXPONENT,
			UFBX_MATERIAL_FBX_REFLECTION_FACTOR,
			UFBX_MATERIAL_FBX_REFLECTION_COLOR,
			UFBX_MATERIAL_FBX_TRANSPARENCY_FACTOR,
			UFBX_MATERIAL_FBX_TRANSPARENCY_COLOR,
			UFBX_MATERIAL_FBX_EMISSION_FACTOR,
			UFBX_MATERIAL_FBX_EMISSION_COLOR,
			UFBX_MATERIAL_FBX_AMBIENT_FACTOR,
			UFBX_MATERIAL_FBX_AMBIENT_COLOR,
			UFBX_MATERIAL_FBX_NORMAL_MAP,
			UFBX_MATERIAL_FBX_BUMP,
			UFBX_MATERIAL_FBX_BUMP_FACTOR,
			UFBX_MATERIAL_FBX_DISPLACEMENT_FACTOR,
			UFBX_MATERIAL_FBX_DISPLACEMENT,
			UFBX_MATERIAL_FBX_VECTOR_DISPLACEMENT_FACTOR,
			UFBX_MATERIAL_FBX_VECTOR_DISPLACEMENT,
			UFBX_MATERIAL_FBX_MAP_FORCE_32BIT = 2147483647
		}
		public enum ufbx_material_pbr_map
		{
			UFBX_MATERIAL_PBR_BASE_FACTOR,
			UFBX_MATERIAL_PBR_BASE_COLOR,
			UFBX_MATERIAL_PBR_ROUGHNESS,
			UFBX_MATERIAL_PBR_METALNESS,
			UFBX_MATERIAL_PBR_DIFFUSE_ROUGHNESS,
			UFBX_MATERIAL_PBR_SPECULAR_FACTOR,
			UFBX_MATERIAL_PBR_SPECULAR_COLOR,
			UFBX_MATERIAL_PBR_SPECULAR_IOR,
			UFBX_MATERIAL_PBR_SPECULAR_ANISOTROPY,
			UFBX_MATERIAL_PBR_SPECULAR_ROTATION,
			UFBX_MATERIAL_PBR_TRANSMISSION_FACTOR,
			UFBX_MATERIAL_PBR_TRANSMISSION_COLOR,
			UFBX_MATERIAL_PBR_TRANSMISSION_DEPTH,
			UFBX_MATERIAL_PBR_TRANSMISSION_SCATTER,
			UFBX_MATERIAL_PBR_TRANSMISSION_SCATTER_ANISOTROPY,
			UFBX_MATERIAL_PBR_TRANSMISSION_DISPERSION,
			UFBX_MATERIAL_PBR_TRANSMISSION_ROUGHNESS,
			UFBX_MATERIAL_PBR_TRANSMISSION_EXTRA_ROUGHNESS,
			UFBX_MATERIAL_PBR_TRANSMISSION_PRIORITY,
			UFBX_MATERIAL_PBR_TRANSMISSION_ENABLE_IN_AOV,
			UFBX_MATERIAL_PBR_SUBSURFACE_FACTOR,
			UFBX_MATERIAL_PBR_SUBSURFACE_COLOR,
			UFBX_MATERIAL_PBR_SUBSURFACE_RADIUS,
			UFBX_MATERIAL_PBR_SUBSURFACE_SCALE,
			UFBX_MATERIAL_PBR_SUBSURFACE_ANISOTROPY,
			UFBX_MATERIAL_PBR_SUBSURFACE_TINT_COLOR,
			UFBX_MATERIAL_PBR_SUBSURFACE_TYPE,
			UFBX_MATERIAL_PBR_SHEEN_FACTOR,
			UFBX_MATERIAL_PBR_SHEEN_COLOR,
			UFBX_MATERIAL_PBR_SHEEN_ROUGHNESS,
			UFBX_MATERIAL_PBR_COAT_FACTOR,
			UFBX_MATERIAL_PBR_COAT_COLOR,
			UFBX_MATERIAL_PBR_COAT_ROUGHNESS,
			UFBX_MATERIAL_PBR_COAT_IOR,
			UFBX_MATERIAL_PBR_COAT_ANISOTROPY,
			UFBX_MATERIAL_PBR_COAT_ROTATION,
			UFBX_MATERIAL_PBR_COAT_NORMAL,
			UFBX_MATERIAL_PBR_COAT_AFFECT_BASE_COLOR,
			UFBX_MATERIAL_PBR_COAT_AFFECT_BASE_ROUGHNESS,
			UFBX_MATERIAL_PBR_THIN_FILM_THICKNESS,
			UFBX_MATERIAL_PBR_THIN_FILM_IOR,
			UFBX_MATERIAL_PBR_EMISSION_FACTOR,
			UFBX_MATERIAL_PBR_EMISSION_COLOR,
			UFBX_MATERIAL_PBR_OPACITY,
			UFBX_MATERIAL_PBR_INDIRECT_DIFFUSE,
			UFBX_MATERIAL_PBR_INDIRECT_SPECULAR,
			UFBX_MATERIAL_PBR_NORMAL_MAP,
			UFBX_MATERIAL_PBR_TANGENT_MAP,
			UFBX_MATERIAL_PBR_DISPLACEMENT_MAP,
			UFBX_MATERIAL_PBR_MATTE_FACTOR,
			UFBX_MATERIAL_PBR_MATTE_COLOR,
			UFBX_MATERIAL_PBR_AMBIENT_OCCLUSION,
			UFBX_MATERIAL_PBR_GLOSSINESS,
			UFBX_MATERIAL_PBR_COAT_GLOSSINESS,
			UFBX_MATERIAL_PBR_TRANSMISSION_GLOSSINESS,
			UFBX_MATERIAL_PBR_MAP_FORCE_32BIT = 2147483647
		}
		public enum ufbx_material_feature
		{
			UFBX_MATERIAL_FEATURE_PBR,
			UFBX_MATERIAL_FEATURE_METALNESS,
			UFBX_MATERIAL_FEATURE_DIFFUSE,
			UFBX_MATERIAL_FEATURE_SPECULAR,
			UFBX_MATERIAL_FEATURE_EMISSION,
			UFBX_MATERIAL_FEATURE_TRANSMISSION,
			UFBX_MATERIAL_FEATURE_COAT,
			UFBX_MATERIAL_FEATURE_SHEEN,
			UFBX_MATERIAL_FEATURE_OPACITY,
			UFBX_MATERIAL_FEATURE_AMBIENT_OCCLUSION,
			UFBX_MATERIAL_FEATURE_MATTE,
			UFBX_MATERIAL_FEATURE_UNLIT,
			UFBX_MATERIAL_FEATURE_IOR,
			UFBX_MATERIAL_FEATURE_DIFFUSE_ROUGHNESS,
			UFBX_MATERIAL_FEATURE_TRANSMISSION_ROUGHNESS,
			UFBX_MATERIAL_FEATURE_THIN_WALLED,
			UFBX_MATERIAL_FEATURE_CAUSTICS,
			UFBX_MATERIAL_FEATURE_EXIT_TO_BACKGROUND,
			UFBX_MATERIAL_FEATURE_INTERNAL_REFLECTIONS,
			UFBX_MATERIAL_FEATURE_DOUBLE_SIDED,
			UFBX_MATERIAL_FEATURE_ROUGHNESS_AS_GLOSSINESS,
			UFBX_MATERIAL_FEATURE_COAT_ROUGHNESS_AS_GLOSSINESS,
			UFBX_MATERIAL_FEATURE_TRANSMISSION_ROUGHNESS_AS_GLOSSINESS,
			UFBX_MATERIAL_FEATURE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_texture_type
		{
			UFBX_TEXTURE_FILE,
			UFBX_TEXTURE_LAYERED,
			UFBX_TEXTURE_PROCEDURAL,
			UFBX_TEXTURE_SHADER,
			UFBX_TEXTURE_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_blend_mode
		{
			UFBX_BLEND_TRANSLUCENT,
			UFBX_BLEND_ADDITIVE,
			UFBX_BLEND_MULTIPLY,
			UFBX_BLEND_MULTIPLY_2X,
			UFBX_BLEND_OVER,
			UFBX_BLEND_REPLACE,
			UFBX_BLEND_DISSOLVE,
			UFBX_BLEND_DARKEN,
			UFBX_BLEND_COLOR_BURN,
			UFBX_BLEND_LINEAR_BURN,
			UFBX_BLEND_DARKER_COLOR,
			UFBX_BLEND_LIGHTEN,
			UFBX_BLEND_SCREEN,
			UFBX_BLEND_COLOR_DODGE,
			UFBX_BLEND_LINEAR_DODGE,
			UFBX_BLEND_LIGHTER_COLOR,
			UFBX_BLEND_SOFT_LIGHT,
			UFBX_BLEND_HARD_LIGHT,
			UFBX_BLEND_VIVID_LIGHT,
			UFBX_BLEND_LINEAR_LIGHT,
			UFBX_BLEND_PIN_LIGHT,
			UFBX_BLEND_HARD_MIX,
			UFBX_BLEND_DIFFERENCE,
			UFBX_BLEND_EXCLUSION,
			UFBX_BLEND_SUBTRACT,
			UFBX_BLEND_DIVIDE,
			UFBX_BLEND_HUE,
			UFBX_BLEND_SATURATION,
			UFBX_BLEND_COLOR,
			UFBX_BLEND_LUMINOSITY,
			UFBX_BLEND_OVERLAY,
			UFBX_BLEND_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_wrap_mode
		{
			UFBX_WRAP_REPEAT,
			UFBX_WRAP_CLAMP,
			UFBX_WRAP_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_shader_texture_type
		{
			UFBX_SHADER_TEXTURE_UNKNOWN,
			UFBX_SHADER_TEXTURE_SELECT_OUTPUT,
			UFBX_SHADER_TEXTURE_OSL,
			UFBX_SHADER_TEXTURE_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_interpolation
		{
			UFBX_INTERPOLATION_CONSTANT_PREV,
			UFBX_INTERPOLATION_CONSTANT_NEXT,
			UFBX_INTERPOLATION_LINEAR,
			UFBX_INTERPOLATION_CUBIC,
			UFBX_INTERPOLATION_FORCE_32BIT = 2147483647
		}
		public enum ufbx_constraint_type
		{
			UFBX_CONSTRAINT_UNKNOWN,
			UFBX_CONSTRAINT_AIM,
			UFBX_CONSTRAINT_PARENT,
			UFBX_CONSTRAINT_POSITION,
			UFBX_CONSTRAINT_ROTATION,
			UFBX_CONSTRAINT_SCALE,
			UFBX_CONSTRAINT_SINGLE_CHAIN_IK,
			UFBX_CONSTRAINT_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_constraint_aim_up_type
		{
			UFBX_CONSTRAINT_AIM_UP_SCENE,
			UFBX_CONSTRAINT_AIM_UP_TO_NODE,
			UFBX_CONSTRAINT_AIM_UP_ALIGN_NODE,
			UFBX_CONSTRAINT_AIM_UP_VECTOR,
			UFBX_CONSTRAINT_AIM_UP_NONE,
			UFBX_CONSTRAINT_AIM_UP_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_constraint_ik_pole_type
		{
			UFBX_CONSTRAINT_IK_POLE_VECTOR,
			UFBX_CONSTRAINT_IK_POLE_NODE,
			UFBX_CONSTRAINT_IK_POLE_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_exporter
		{
			UFBX_EXPORTER_UNKNOWN,
			UFBX_EXPORTER_FBX_SDK,
			UFBX_EXPORTER_BLENDER_BINARY,
			UFBX_EXPORTER_BLENDER_ASCII,
			UFBX_EXPORTER_MOTION_BUILDER,
			UFBX_EXPORTER_BC_UNITY_EXPORTER,
			UFBX_EXPORTER_FORCE_32BIT = 2147483647
		}
		public enum ufbx_file_format
		{
			UFBX_FILE_FORMAT_UNKNOWN,
			UFBX_FILE_FORMAT_FBX,
			UFBX_FILE_FORMAT_OBJ,
			UFBX_FILE_FORMAT_MTL,
			UFBX_FILE_FORMAT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_warning_type
		{
			UFBX_WARNING_MISSING_EXTERNAL_FILE,
			UFBX_WARNING_IMPLICIT_MTL,
			UFBX_WARNING_TRUNCATED_ARRAY,
			UFBX_WARNING_INDEX_CLAMPED,
			UFBX_WARNING_BAD_UNICODE,
			UFBX_WARNING_BAD_ELEMENT_CONNECTED_TO_ROOT,
			UFBX_WARNING_DUPLICATE_OBJECT_ID,
			UFBX_WARNING_EMPTY_FACE_REMOVED,
			UFBX_WARNING_UNKNOWN_OBJ_DIRECTIVE,
			UFBX_WARNING_TYPE_FIRST_DEDUPLICATED = 0,
			UFBX_WARNING_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_time_mode
		{
			UFBX_TIME_MODE_DEFAULT,
			UFBX_TIME_MODE_120_FPS,
			UFBX_TIME_MODE_100_FPS,
			UFBX_TIME_MODE_60_FPS,
			UFBX_TIME_MODE_50_FPS,
			UFBX_TIME_MODE_48_FPS,
			UFBX_TIME_MODE_30_FPS,
			UFBX_TIME_MODE_30_FPS_DROP,
			UFBX_TIME_MODE_NTSC_DROP_FRAME,
			UFBX_TIME_MODE_NTSC_FULL_FRAME,
			UFBX_TIME_MODE_PAL,
			UFBX_TIME_MODE_24_FPS,
			UFBX_TIME_MODE_1000_FPS,
			UFBX_TIME_MODE_FILM_FULL_FRAME,
			UFBX_TIME_MODE_CUSTOM,
			UFBX_TIME_MODE_96_FPS,
			UFBX_TIME_MODE_72_FPS,
			UFBX_TIME_MODE_59_94_FPS,
			UFBX_TIME_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_time_protocol
		{
			UFBX_TIME_PROTOCOL_SMPTE,
			UFBX_TIME_PROTOCOL_FRAME_COUNT,
			UFBX_TIME_PROTOCOL_DEFAULT,
			UFBX_TIME_PROTOCOL_FORCE_32BIT = 2147483647
		}
		public enum ufbx_snap_mode
		{
			UFBX_SNAP_MODE_NONE,
			UFBX_SNAP_MODE_SNAP,
			UFBX_SNAP_MODE_PLAY,
			UFBX_SNAP_MODE_SNAP_AND_PLAY,
			UFBX_SNAP_MODE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_topo_flags
		{
			UFBX_TOPO_NON_MANIFOLD = 1,
			UFBX_TOPO_FLAGS_FORCE_32BIT = 2147483647
		}
		public enum ufbx_open_file_type
		{
			UFBX_OPEN_FILE_MAIN_MODEL,
			UFBX_OPEN_FILE_GEOMETRY_CACHE,
			UFBX_OPEN_FILE_OBJ_MTL,
			UFBX_OPEN_FILE_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_error_type
		{
			UFBX_ERROR_NONE,
			UFBX_ERROR_UNKNOWN,
			UFBX_ERROR_FILE_NOT_FOUND,
			UFBX_ERROR_OUT_OF_MEMORY,
			UFBX_ERROR_MEMORY_LIMIT,
			UFBX_ERROR_ALLOCATION_LIMIT,
			UFBX_ERROR_TRUNCATED_FILE,
			UFBX_ERROR_IO,
			UFBX_ERROR_CANCELLED,
			UFBX_ERROR_UNRECOGNIZED_FILE_FORMAT,
			UFBX_ERROR_UNINITIALIZED_OPTIONS,
			UFBX_ERROR_ZERO_VERTEX_SIZE,
			UFBX_ERROR_INVALID_UTF8,
			UFBX_ERROR_FEATURE_DISABLED,
			UFBX_ERROR_BAD_NURBS,
			UFBX_ERROR_BAD_INDEX,
			UFBX_ERROR_UNSAFE_OPTIONS,
			UFBX_ERROR_TYPE_FORCE_32BIT = 2147483647
		}
		public enum ufbx_progress_result
		{
			UFBX_PROGRESS_CONTINUE = 256,
			UFBX_PROGRESS_CANCEL = 512,
			UFBX_PROGRESS_RESULT_FORCE_32BIT = 2147483647
		}
		public enum ufbx_index_error_handling
		{
			UFBX_INDEX_ERROR_HANDLING_CLAMP,
			UFBX_INDEX_ERROR_HANDLING_NO_INDEX,
			UFBX_INDEX_ERROR_HANDLING_ABORT_LOADING,
			UFBX_INDEX_ERROR_HANDLING_UNSAFE_IGNORE,
			UFBX_INDEX_ERROR_HANDLING_FORCE_32BIT = 2147483647
		}
		public enum ufbx_unicode_error_handling
		{
			UFBX_UNICODE_ERROR_HANDLING_REPLACEMENT_CHARACTER,
			UFBX_UNICODE_ERROR_HANDLING_UNDERSCORE,
			UFBX_UNICODE_ERROR_HANDLING_QUESTION_MARK,
			UFBX_UNICODE_ERROR_HANDLING_REMOVE,
			UFBX_UNICODE_ERROR_HANDLING_ABORT_LOADING,
			UFBX_UNICODE_ERROR_HANDLING_UNSAFE_IGNORE,
			UFBX_UNICODE_ERROR_HANDLING_FORCE_32BIT = 2147483647
		}
		public enum ufbx_geometry_transform_handling
		{
			UFBX_GEOMETRY_TRANSFORM_HANDLING_PRESERVE,
			UFBX_GEOMETRY_TRANSFORM_HANDLING_HELPER_NODES,
			UFBX_GEOMETRY_TRANSFORM_HANDLING_MODIFY_GEOMETRY,
			UFBX_GEOMETRY_TRANSFORM_HANDLING_MODIFY_GEOMETRY_NO_FALLBACK,
			UFBX_GEOMETRY_TRANSFORM_HANDLING_FORCE_32BIT = 2147483647
		}
		public enum ufbx_space_conversion
		{
			UFBX_SPACE_CONVERSION_TRANSFORM_ROOT,
			UFBX_SPACE_CONVERSION_ADJUST_TRANSFORMS,
			UFBX_SPACE_CONVERSION_FORCE_32BIT = 2147483647
		}
	}
}