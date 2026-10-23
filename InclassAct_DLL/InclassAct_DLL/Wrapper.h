#pragma once
#ifndef _WRAPPER_
#define _WRAPPER_

#include "Vector2D.h"
#include "PluginSettings.h"

#ifdef __cplusplus
extern "C"
{
#endif // _cplusplus
	PLUGIN_API int GetID();

	PLUGIN_API void SetID(int id);

	PLUGIN_API Vector2D GetPosition();

	PLUGIN_API void SetPosition(float x,float y);

#ifdef __cplusplus
}
#endif


#endif // !_WRAPPER_


