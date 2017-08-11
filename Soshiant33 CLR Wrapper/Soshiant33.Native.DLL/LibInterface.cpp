#include <boost/thread.hpp> 
#include "LibInterface.h"

#define SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,property,value) {mutex.lock();if(pointer)pointer->property=value;mutex.unlock();}
#define SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,method) {mutex.lock();if(pointer)pointer->method;mutex.unlock();}
#define SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(Type,args) {mutex.lock();Type* temp=new Type args;mutex.unlock();return temp;}
#define SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,property,operator) {if(pointer)return operator pointer->property;return 0;}
#define SAFE_THREAD_RELEASE_POINTER(pointer) {mutex.lock();SAFE_DELETE(pointer);mutex.unlock();}

S33Engine* engine =0;
boost::mutex mutex;
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Engine Methods
//--------------------------------------------------------------------------------------------
S33Engine* Engine_New(unsigned int width,unsigned int height,bool fullscreen,HWND clientHandle)
{
	SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(S33Engine,(width,height,fullscreen,clientHandle));
}
void Engine_Resize(S33Engine* pointer,unsigned int width,unsigned int height,bool resetBackbufferSize)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,ReSize(width,height,resetBackbufferSize));
}
void Engine_Fullscreen(S33Engine* pointer,bool value)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Fullscreen(value));
}
void Engine_SetWindowHandle(S33Engine* pointer,HWND value)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetWindowHandle(value));

}
void Engine_SetFillMode(S33Engine* pointer,SPRenderer::FillMode value)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,GetRenderer()->SetFillMode(value));
}
void Engine_ClearBackBuffer(S33Engine* pointer,DWORD value)
{
	mutex.lock();
	if(pointer)
	{
		SPColor color(0,0,0,0);
		color.value = value;
		pointer->GetRenderer()->ClearBackBuffer(&color);
	}
	mutex.unlock();
}
SPCamera* Engine_GetCamera(S33Engine* pointer)
{
	if(pointer)
		return pointer->GetRenderer()->GetCamera();
	else
		return 0;
}
void Engine_Release(S33Engine* pointer)
{
	SAFE_THREAD_RELEASE_POINTER(pointer);
}
void Engine_Lock()
{
	mutex.lock();
}
void Engine_UnLock()
{
	mutex.unlock();
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Scene Methods
//--------------------------------------------------------------------------------------------
void Scene_SetPositionIteration(S33Scene* pointer,unsigned short value)
{
	mutex.lock();
	if(pointer)
		pointer->positionIteration = value;
	mutex.unlock();
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,positionIteration,value);
}
void Scene_SetVelocityIteration(S33Scene* pointer,unsigned short value)
{
	mutex.lock(); 
	if(pointer)
		pointer->velocityIteration = value;
	mutex.unlock();
}
unsigned short Scene_GetPositionIteration(S33Scene* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,positionIteration,);
}
unsigned short Scene_GetVelocityIteration(S33Scene* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,velocityIteration,);
}
void Scene_SetBackColor(S33Scene* pointer,DWORD value)
{
	mutex.lock();
	if(pointer)
		pointer->backColor.value = value;
	mutex.unlock();
}
DWORD Scene_GetBackColor(S33Scene* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,backColor.value,);
}
void Scene_Play(S33Scene* pointer)
{
	mutex.lock();
	if(pointer)
		pointer->Paly();
	mutex.unlock();
}
void Scene_Pause(S33Scene* pointer)
{
	mutex.lock();
	if(pointer)
		pointer->Pause();
	mutex.unlock();
}
b2World* Scene_GetWorld(S33Scene* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,world,);
}
void Scene_SaveAsScenePattern(S33Scene* pointer,const char* filename)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SaveAsScenePattern(filename));
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Scene Pattern Methods
//--------------------------------------------------------------------------------------------
S33ScenePattern* ScenePattern_New()
{
	//MessageBox(0,"asdas",0,0);
	//S33ScenePattern* temp = new S33ScenePattern();
	SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(S33ScenePattern,());
	//MessageBox(0,"asdas~~~~~~~~~~~~~~~~~~",0,0);
	//return temp;
}
b2Vec2* ScenePattern_GetGravity(S33ScenePattern* pattern)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pattern,gravity,&);
}
void ScenePattern_SetDoSleep(S33ScenePattern* pointer,bool value)
{
	mutex.lock();
	if(pointer)
		pointer->doSleep = value;
	mutex.unlock();
}
int ScenePattern_GetDoSleep(S33ScenePattern* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,doSleep,);
}
void ScenePattern_SetBackColor(S33ScenePattern* pointer,DWORD value)
{
	mutex.lock();
	if(pointer)
		pointer->backColor.value = value;
	mutex.unlock();
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Sprite Pattern Methods
//--------------------------------------------------------------------------------------------
S33SpritePattern* SpritePattern_New()
{
	SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(S33SpritePattern,());
}
S33SpriteState* SpritePattern_AddNewState(S33SpritePattern* pointer,const char* name)
{
	mutex.lock();
	S33SpriteState* temp = 0;
	if(pointer)
		temp = pointer->AddNewState(name);
	mutex.unlock();
	return temp;
}
void SpritePattern_RemoveState(S33SpritePattern* pointer,unsigned short index)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,RemoveState(index));
}
b2BodyDef* SpritePattern_GetBodyDef(S33SpritePattern* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,bodyDef,&);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Sprite State Methods
//--------------------------------------------------------------------------------------------
void SpriteState_SetName(S33SpriteState* pointer,const char* value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,name,value);
}
void SpriteState_SetGraphic(S33SpriteState* pointer,const char* value)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetGraphic(value));
}
const char* SpriteState_GetName(S33SpriteState* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,name.c_str(),);
}
const char* SpriteState_GetGraphic(S33SpriteState* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,graphic.c_str(),);
}
void SpriteState_SetFPS(S33SpriteState* pointer,unsigned short fps)
{
	mutex.lock();
	if(pointer)
		pointer->frameTimeLenght = 1000/fps;
	mutex.unlock();
}
S33KeyFrame* SpriteState_AddNewKeyFrame(S33SpriteState* pointer,int subsetIndex)
{
	mutex.lock();
	S33KeyFrame* temp = 0;
	if(pointer)
		temp = pointer->AddKeyFrame(subsetIndex);
	mutex.unlock();
	return temp;
}
void SpriteState_RemoveKeyFrame(S33SpriteState* pointer,unsigned short index)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,RemoveKeyFrame(index));
}
void SpriteState_SetCurrentFrame(S33SpriteState* pointer,unsigned short index)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,currentFrame,index);
}
unsigned short SpriteState_GetGraphicSubsetsCount(S33SpriteState* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetGraphic()->subsetsCount,);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Sprite Methods
//--------------------------------------------------------------------------------------------
unsigned short Sprite_GetCurrentState(S33Sprite* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,currentState,);
}
void Sprite_SetCurrentState(S33Sprite* pointer,unsigned short value)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SwitchState(value));
}
b2Body* Sprite_GetBody(S33Sprite* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,body,);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//KeyFrame Methods
//--------------------------------------------------------------------------------------------
const char* KeyFrame_GetActionFuncName(S33KeyFrame* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,actionFuncName.c_str(),);
}
void KeyFrame_SetActionFuncName(S33KeyFrame* pointer,const char* value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,actionFuncName,value);
}
int KeyFrame_GetSubsetIndex(S33KeyFrame* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,subsetIndex,);
}
void KeyFrame_SetSubsetIndex(S33KeyFrame* pointer,int value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,subsetIndex,value);
}
int KeyFrame_GetHasAction(S33KeyFrame* pointer)
{	
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,hasAction,);
}
void KeyFrame_SetHasAction(S33KeyFrame* pointer,bool value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,hasAction,value)
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Entity Pattern Methods
//--------------------------------------------------------------------------------------------
void EntityPattern_SetName(S33EntityPattern* pointer,const char* value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,name,value);
}
const char* EntityPattern_GetName(S33EntityPattern* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,name.c_str(),);
}
S33EntityPattern::Types EntityPattern_GetType(S33EntityPattern* pointer)
{ 
	if(pointer)
		return pointer->type;
	else
		return S33EntityPattern::Type_EntityPattern;
}
void EntityPattern_SetType(S33EntityPattern* pointer,S33EntityPattern::Types value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,type,value);
}
void EntityPattern_SetScript(S33EntityPattern* pointer,const char* value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,script,value);
}
const char* EntityPattern_GetScript(S33EntityPattern* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,script.c_str(),);
}
void EntityPattern_Save(S33EntityPattern* pointer,const char* filename)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Save(filename));
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Entity Methods
//--------------------------------------------------------------------------------------------
S33EntityParameters* Entity_GetEP(S33Entity* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,ep,&);
}
void Entity_Release(S33Entity* pointer)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,isAlive,false);
}
void Entity_Update(S33Entity* pointer)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Update());
}
void Entity_Render(S33Entity* pointer)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Render());
}
S33Entity* Entity_Pick(S33Entity* pointer,int x, int y)
{
	mutex.lock();
	POINT point;
	point.x = x;
	point.y = y;	
	S33Entity* picked = pointer->Pick(&point);
	mutex.unlock();
	return picked;
}
S33EntityPattern* Entity_GetPattern(S33Entity* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,pattern,);
}
S33Entity::Types Entity_GetType(S33Entity* pointer)
{
	//SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,type,);
	if(pointer)
		return pointer->type;
	else
		return S33Entity::Type_Entity;
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Camera Methods
//--------------------------------------------------------------------------------------------
void Camera_Fly(SPCamera* pointer,float units)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Fly(units));
}
void Camera_Walk(SPCamera* pointer,float units)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Walk(units));
}
void Camera_Strafe(SPCamera* pointer,float units)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Strafe(units));
}
void Camera_SetProjectionType(SPCamera* pointer,SPCamera::ProjectionTypes type)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetProjection(type));
}
SPCamera::ProjectionTypes Camera_GetProjectionType(SPCamera* pointer)
{
	if(pointer)
		return pointer->GetProjectionType();
	else
		return SPCamera::ProjectionType_Perspective;
}
void Camera_Yaw(SPCamera* pointer,float angle)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Yaw(angle));
}
void Camera_Roll(SPCamera* pointer,float angle)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Roll(angle));
}
void Camera_Pitch(SPCamera* pointer,float angle)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,Pitch(angle));
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//SPVector3 Methods
//--------------------------------------------------------------------------------------------
SPVector3* Vector3_New()
{
	SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(SPVector3,());
}
float Vector3_GetX(SPVector3* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,x,);
}
float Vector3_GetY(SPVector3* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,y,);
}
float Vector3_GetZ(SPVector3* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,z,);
}
void Vector3_SetX(SPVector3* pointer,float value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,x,value);
}
void Vector3_SetY(SPVector3* pointer,float value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,y,value);
}
void Vector3_SetZ(SPVector3* pointer,float value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,z,value);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//S33EntityParameters Methods
//--------------------------------------------------------------------------------------------
S33EntityParameters* EntityParameters_New()
{
	SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(S33EntityParameters,());
}
SPVector3* EntityParameters_GetPosition(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,position,&);
}
SPVector3* EntityParameters_GetRotation(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,rotation,&);
}
SPVector3* EntityParameters_GetScale(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,scale,&);
}
const char* EntityParameters_GetName(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,name.c_str(),);
}
void EntityParameters_SetName(S33EntityParameters* pointer,const char* value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,name,value);
}
int EntityParameters_GetVisible(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,visible,);
}
void EntityParameters_SetVisible(S33EntityParameters* pointer,bool value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,visible,value);
}
void EntityParameters_SetColor(S33EntityParameters* pointer,unsigned char r,unsigned char g,unsigned char b,unsigned char a)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,material.Set(r/255.0f,g/255.0f,b/255.0f,a/255.0f));
}
DWORD EntityParameters_GetColor(S33EntityParameters* pointer)
{
	return SPColor((unsigned char)(pointer->material.Diffuse.r*255),(unsigned char)(pointer->material.Diffuse.g*255),(unsigned char)(pointer->material.Diffuse.b*255),(unsigned char)(pointer->material.Diffuse.a*255)).value;
}
void EntityParameters_SetTransparency(S33EntityParameters* pointer,unsigned char value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,material.Diffuse.a,value/255.0f);
}
unsigned char EntityParameters_GetTransparency(S33EntityParameters* pointer)
{
	return unsigned char(pointer->material.Diffuse.a*255);
}
unsigned char EntityParameters_GetBlendingMode(S33EntityParameters* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,blendMode,);
}
void EntityParameters_SetBlendingMode(S33EntityParameters* pointer,SPRenderingParameters::BlendingMode value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,blendMode,value);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//S33ComplexEntity Methods
//--------------------------------------------------------------------------------------------
S33Entity* ComplexEntity_AddChild(S33ComplexEntity* pointer,S33EntityPattern* pattern,S33EntityParameters* ep)
{
	mutex.lock();
	S33Entity* output = 0;
	if(pointer)
		output = pointer->AddChild(pattern,ep);
	mutex.unlock();
	return output;
}

void ComplexEntity_SortChildsByDepth(S33ComplexEntity* pointer)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SortChildsByDepth());
}
void ComplexEntity_SaveAsComplexEntityPattern(S33ComplexEntity* pointer,const char* filename)
{
	SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SaveAsComplexEntityPattern(filename));
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//S33ComplexEntity Methods
//--------------------------------------------------------------------------------------------
SPRect* Rect_New()
{
	return new SPRect(0,0,1,1);
}
int Rect_GetTop(SPRect* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,top,);
}
int Rect_GetBottom(SPRect* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,bottom,);
}
int Rect_GetLeft(SPRect* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,left,);
}
int Rect_GetRight(SPRect* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,right,);
}
void Rect_SetTop(SPRect* pointer,int value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,top,value);
}
void Rect_SetBottom(SPRect* pointer,int value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,bottom,value);
}
void Rect_SetLeft(SPRect* pointer,int value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,left,value);
}
void Rect_SetRight(SPRect* pointer,int value)
{
	SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,right,value);
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//Library Methods
//--------------------------------------------------------------------------------------------
S33ScenePattern* Library_GetScenePattern(const char* name)
{
	mutex.lock();
	S33ScenePattern* temp = S33Library::GetScenePattern(name);
	mutex.unlock();
	return temp;
}
S33SpritePattern* Library_GetSpritePattern(const char* name)
{
	mutex.lock();
	S33SpritePattern* temp = S33Library::GetSpritePattern(name);
	mutex.unlock();
	return temp;
}
S33ComplexEntityPattern* Library_GetComplexEntityPattern(const char* name)
{
	mutex.lock();
	S33ComplexEntityPattern* temp = S33Library::GetComplexEntityPattern(name);
	mutex.unlock();
	return temp;
}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2Vec2 Methods
//--------------------------------------------------------------------------------------------
b2Vec2* b2Vec2_New(){SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(b2Vec2,());}
float b2Vec2_GetX(b2Vec2* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,x,);}
float b2Vec2_GetY(b2Vec2* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,y,);}
void b2Vec2_SetX(b2Vec2* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,x,value);}
void b2Vec2_SetY(b2Vec2* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,y,value);}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2Shape Methods
//--------------------------------------------------------------------------------------------
b2Shape::Type b2Shape_GetType(b2Shape* pointer)
{ 
	if(pointer)
		return pointer->m_type;
	else
		return b2Shape::e_unknown;
}
void b2Shape_SetType(b2Shape* pointer,b2Shape::Type value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,m_type,value);}
float b2Shape_GetRadius(b2Shape* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,m_radius,);}
void  b2Shape_SetRadius(b2Shape* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,m_radius,value);}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2CircleShape Methods
//--------------------------------------------------------------------------------------------
b2CircleShape* b2CircleShape_New(){ SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(b2CircleShape,());}
b2Vec2* b2CircleShape_GetPosition(b2CircleShape* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,m_p,&); }
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2PolygonShape Methods
//--------------------------------------------------------------------------------------------
b2PolygonShape* b2PolygonShape_New(){ SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(b2PolygonShape,());}
b2Vec2* b2PolygonShape_GetCentroid(b2PolygonShape* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,m_centroid,&);}
b2Vec2* b2PolygonShape_GetVertex(b2PolygonShape* pointer,int index){SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,m_vertices[index],&);}
int b2PolygonShape_GetVertexesCount(b2PolygonShape* pointer){SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,m_vertexCount,);}
void b2PolygonShape_SetVertexesCount(b2PolygonShape* pointer,int value){SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,m_vertexCount,value);}
void b2PolygonShape_SetAsBox(b2PolygonShape* pointer,float width,float height){SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetAsBox(width/2,height/2));}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2FixtureDef Methods
//--------------------------------------------------------------------------------------------
b2FixtureDef* b2FixtureDef_New(){ SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(b2FixtureDef,());}
b2Shape* b2FixtureDef_GetShape(b2FixtureDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,shape,(b2Shape*));}
float b2FixtureDef_GetFriction(b2FixtureDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,friction,);}
float b2FixtureDef_GetRistitution(b2FixtureDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,restitution,);}
float b2FixtureDef_GetDensity(b2FixtureDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,density,);}
int b2FixtureDef_GetIsSensor(b2FixtureDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,isSensor,);}
void b2FixtureDef_SetShape(b2FixtureDef* pointer,b2Shape* value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,shape,value);}
void b2FixtureDef_SetFriction(b2FixtureDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,friction,value);}
void b2FixtureDef_SetRistitution(b2FixtureDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,restitution,value);}
void b2FixtureDef_SetDensity(b2FixtureDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,density,value);}
void b2FixtureDef_SetIsSensor(b2FixtureDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,isSensor,value);}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2FixtureDef Methods
//--------------------------------------------------------------------------------------------	
b2Fixture* b2Fixture_GetNext(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetNext(),);}
b2Shape* b2Fixture_GetShape(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetShape(),);}
float b2Fixture_GetFriction(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetFriction(),);}
float b2Fixture_GetRistitution(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetRestitution(),);}
float b2Fixture_GetDensity(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetDensity(),);}
int b2Fixture_GetIsSensor(b2Fixture* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsSensor(),);}
void b2Fixture_SetFriction(b2Fixture* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetFriction(value));}
void b2Fixture_SetRistitution(b2Fixture* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetRestitution(value));}
void b2Fixture_SetDensity(b2Fixture* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetDensity(value));}
void b2Fixture_SetIsSensor(b2Fixture* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetSensor(value));}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2BodyDef Methods
//--------------------------------------------------------------------------------------------	
b2BodyDef* b2BodyDef_New(){ SAFE_THREAD_CREATE_AND_RETURN_NEW_POINTER(b2BodyDef,());}
b2Vec2* b2BodyDef_GetPosition(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,position,&);}
b2Vec2* b2BodyDef_GetLinearVelocity(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,linearVelocity,&);}
b2BodyType b2BodyDef_GetType(b2BodyDef* pointer)
{ 
	if(pointer)
		return pointer->type;
	else
		return b2_staticBody;
}
float b2BodyDef_GetAngle(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,angle,);}
float b2BodyDef_GetAngularVelocity(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,angularVelocity,);}
float b2BodyDef_GetLinearDamping(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,linearDamping,);}
float b2BodyDef_GetAngularDamping(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,angularDamping,);}
int b2BodyDef_GetAllowSleep(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,allowSleep,);}
int b2BodyDef_GetAwake(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,awake,);}
int b2BodyDef_GetFixedRotation(b2BodyDef* pointer)
{
	SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,fixedRotation,);
}
int b2BodyDef_GetBullet(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,bullet,);}
int b2BodyDef_GetActive(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,active,);}
float b2BodyDef_GetInertiaScale(b2BodyDef* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,inertiaScale,);}
void b2BodyDef_SetType(b2BodyDef* pointer,b2BodyType value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,type,value);}
void b2BodyDef_SetAngle(b2BodyDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,angle,value);}
void b2BodyDef_SetAngularVelocity(b2BodyDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,angularVelocity,value);}
void b2BodyDef_SetLinearDamping(b2BodyDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,linearDamping,value);}
void b2BodyDef_SetAngularDamping(b2BodyDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,angularDamping,value);}
void b2BodyDef_SetAllowSleep(b2BodyDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,allowSleep,value);}
void b2BodyDef_SetAwake(b2BodyDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,awake,value);}
void b2BodyDef_SetFixedRotation(b2BodyDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,fixedRotation,value);}
void b2BodyDef_SetBullet(b2BodyDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,bullet,value);}
void b2BodyDef_SetActive(b2BodyDef* pointer,bool value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,active,value);}
void b2BodyDef_SetInertiaScale(b2BodyDef* pointer,float value){ SAFE_THREAD_FILL_POINTER_PROPERTY(pointer,inertiaScale,value);}
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//b2Vec2 Methods
//--------------------------------------------------------------------------------------------
class _b2Body:public b2Body
{
public:
	b2Vec2* _GetPosition(){return &this->m_xf.position;}
};
b2Vec2* b2Body_GetPosition(b2Body* pointer){SAFE_THREAD_RETURN_POINTER_PROPERTY(((_b2Body*)pointer),_GetPosition(),); }
b2BodyType b2Body_GetType(b2Body* pointer)
{ 
	if(pointer)
		return pointer->GetType();
	else
		return b2_staticBody;
}
float b2Body_GetAngle(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetAngle(),); }
float b2Body_GetAngularVelocity(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetAngularVelocity(),); }
float b2Body_GetLinearDamping(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetLinearDamping(),); }
float b2Body_GetAngularDamping(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetAngularDamping(),); }
int b2Body_GetAllowSleep(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsSleepingAllowed(),); }
int b2Body_GetAwake(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsAwake(),); }
int b2Body_GetFixedRotation(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsFixedRotation(),); }
int b2Body_GetBullet(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsBullet(),); }
int b2Body_GetActive(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,IsActive(),); }
void b2Body_SetType(b2Body* pointer,b2BodyType value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetType(value)); }
void b2Body_SetAngularVelocity(b2Body* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetAngularVelocity(value)); }
void b2Body_SetLinearDamping(b2Body* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetLinearDamping(value)); }
void b2Body_SetAngularDamping(b2Body* pointer,float value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetAngularDamping(value)); }
void b2Body_SetAllowSleep(b2Body* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetSleepingAllowed(value)); }
void b2Body_SetAwake(b2Body* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetAwake(value)); }
void b2Body_SetFixedRotation(b2Body* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetFixedRotation(value)); }
void b2Body_SetBullet(b2Body* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetBullet(value)); }
void b2Body_SetActive(b2Body* pointer,bool value){ SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,SetActive(value)); }
void b2Body_CreateFixture(b2Body* pointer,b2FixtureDef* value){SAFE_THREAD_CALL_POINTER_VOID_METHOD(pointer,CreateFixture(value));}
b2Fixture* b2Body_GetFixtureList(b2Body* pointer){ SAFE_THREAD_RETURN_POINTER_PROPERTY(pointer,GetFixtureList(),);} 

//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------

int main()
{
	SPLoopManager loopman;
	loopman.AllowSleep(true);
	S33ScenePattern* scenePattern = new S33ScenePattern();
	S33Engine engine;//(1366,768,true);
	S33Scene* scene = (S33Scene*)engine.AddChild(scenePattern,0);
	S33SpritePattern* spritePattern = Library_GetSpritePattern("test.sprt");//S33Library::GetSpritePattern("test.sprt");//new S33SpritePattern();
	/*S33SpriteState* spriteState = spritePattern->AddNewState("State0");
	spriteState->SetGraphic("SpriteSheet_06.x");
	for(unsigned int i =0;i< spriteState->GetGraphic()->subsetsCount;i++)
		spriteState->AddKeyFrame(i);
	spriteState->frameTimeLenght = 1000/150;
	spritePattern->Save("Ptrn\\test.sprt");*/
	spritePattern->states[0]->frameTimeLenght = 1000/1;
	S33EntityParameters ep;
	ep.position.z = 800;
	for(int i=0;i<100;i++)
	{
		ep.position.x = rand()%8600 - 300;
		ep.position.z -=17;
		ep.material.Set(1,Math::Random(),1,1);
		S33Sprite* sprite = (S33Sprite*)scene->AddChild(spritePattern,&ep);
	}


	float r = 0;
	while(!engine.GetWindow()->IsWindowClosed())
	{	
		loopman.BeginLoop();
		SPWindow::ProcessMessages();
		engine.Update();
		//scene->backColor.value ++;
		//sprite->ep.position.z-=sinf(r+=0.07f)*5;
		//sprite->ep.rotation.y=sinf(r)*1;
		engine.GetRenderer()->GetCamera()->Strafe(0.7f);
		engine.GetRenderer()->GetCamera()->Fly(sinf(r+=0.07f)*4);
		loopman.EndLoop();
	}
	S33Library::RemoveItems(0);

	



	return 0;
}


int Tester(void* handle)
{
	mutex.lock();
	mutex.unlock();
	return 0;
}

