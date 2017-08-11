#include <Soshiant33.h>
using namespace Soshiant33;

extern "C" {
	__declspec(dllexport)    int		                Tester(void *handle);

	__declspec(dllexport)    void		                Engine_Lock();	
	__declspec(dllexport)    void		                Engine_UnLock();	
	__declspec(dllexport)    S33Engine*				    Engine_New(unsigned int width,unsigned int height,bool fullscreen,HWND clientHandle);
	__declspec(dllexport)    void		                Engine_Resize(S33Engine* pointer,unsigned int width,unsigned int height,bool resetBackbufferSize);
	__declspec(dllexport)    SPCamera*                  Engine_GetCamera(S33Engine* pointer);
	__declspec(dllexport)    void		                Engine_Fullscreen(S33Engine* pointer,bool value);	
	__declspec(dllexport)    void		                Engine_Release(S33Engine* pointer);	
	__declspec(dllexport)    void		                Engine_ClearBackBuffer(S33Engine* pointer,DWORD value);	
	__declspec(dllexport)    void		                Engine_SetWindowHandle(S33Engine* pointer,HWND value);
	__declspec(dllexport)    void		                Engine_SetFillMode(S33Engine* pointer,SPRenderer::FillMode value);

	__declspec(dllexport)    void		                Scene_SetPositionIteration(S33Scene* pointer,unsigned short value);
	__declspec(dllexport)    void		                Scene_SetVelocityIteration(S33Scene* pointer,unsigned short value);
	__declspec(dllexport)    unsigned short             Scene_GetPositionIteration(S33Scene* pointer);
	__declspec(dllexport)    unsigned short             Scene_GetVelocityIteration(S33Scene* pointer);
	__declspec(dllexport)    void		                Scene_SetBackColor(S33Scene* pointer,DWORD value);
	__declspec(dllexport)    DWORD		                Scene_GetBackColor(S33Scene* pointer);
	__declspec(dllexport)    void		                Scene_Play(S33Scene* pointer);
	__declspec(dllexport)    void		                Scene_Pause(S33Scene* pointer);
	__declspec(dllexport)    b2World*	                Scene_GetWorld(S33Scene* pointer);
	__declspec(dllexport)    void		                Scene_SaveAsScenePattern(S33Scene* pointer,const char* filename);

	__declspec(dllexport)    S33ScenePattern*           ScenePattern_New();
	__declspec(dllexport)    b2Vec2*                    ScenePattern_GetGravity(S33ScenePattern* pattern);
	__declspec(dllexport)    void		                ScenePattern_SetDoSleep(S33ScenePattern* pointer,bool value);
	__declspec(dllexport)    int		                ScenePattern_GetDoSleep(S33ScenePattern* pointer);
	__declspec(dllexport)    void		                ScenePattern_SetBackColor(S33ScenePattern* pointer,DWORD value);
 
	__declspec(dllexport)    S33SpritePattern*          SpritePattern_New();
	__declspec(dllexport)    S33SpriteState*            SpritePattern_AddNewState(S33SpritePattern* pointer,const char* name);
	__declspec(dllexport)    b2BodyDef*                 SpritePattern_GetBodyDef(S33SpritePattern* pointer);
	__declspec(dllexport)    void		                SpritePattern_RemoveState(S33SpritePattern* pointer,unsigned short index);

	__declspec(dllexport)    void		                SpriteState_SetName(S33SpriteState* pointer,const char* value);
	__declspec(dllexport)    const char*                SpriteState_GetName(S33SpriteState* pointer);
	__declspec(dllexport)    const char*                SpriteState_GetGraphic(S33SpriteState* pointer);
	__declspec(dllexport)    void		                SpriteState_SetGraphic(S33SpriteState* pointer,const char* value);
	__declspec(dllexport)    void		                SpriteState_SetFPS(S33SpriteState* pointer,unsigned short fps);
	__declspec(dllexport)    S33KeyFrame*               SpriteState_AddNewKeyFrame(S33SpriteState* pointer,int subsetIndex);
	__declspec(dllexport)    void		                SpriteState_RemoveKeyFrame(S33SpriteState* pointer,unsigned short index);
	__declspec(dllexport)    void		                SpriteState_SetCurrentFrame(S33SpriteState* pointer,unsigned short index);
	__declspec(dllexport)    unsigned short             SpriteState_GetGraphicSubsetsCount(S33SpriteState* pointer);

	__declspec(dllexport)    b2Body*                    Sprite_GetBody(S33Sprite* pointer);
	__declspec(dllexport)    unsigned short             Sprite_GetCurrentState(S33Sprite* pointer);
	__declspec(dllexport)    void		                Sprite_SetCurrentState(S33Sprite* pointer,unsigned short value);

	__declspec(dllexport)    const char*                KeyFrame_GetActionFuncName(S33KeyFrame* pointer);
	__declspec(dllexport)    void		                KeyFrame_SetActionFuncName(S33KeyFrame* pointer,const char* value);
	__declspec(dllexport)    int		                KeyFrame_GetSubsetIndex(S33KeyFrame* pointer);
	__declspec(dllexport)    void		                KeyFrame_SetSubsetIndex(S33KeyFrame* pointer,int value);
	__declspec(dllexport)    int		                KeyFrame_GetHasAction(S33KeyFrame* pointer);
	__declspec(dllexport)    void		                KeyFrame_SetHasAction(S33KeyFrame* pointer,bool value);

	__declspec(dllexport)    void		                Camera_Fly(SPCamera* pointer,float units);
	__declspec(dllexport)    void		                Camera_Walk(SPCamera* pointer,float units);
	__declspec(dllexport)    void		                Camera_Strafe(SPCamera* pointer,float units);
	__declspec(dllexport)    void		                Camera_Yaw(SPCamera* pointer,float angle);
	__declspec(dllexport)    void		                Camera_Roll(SPCamera* pointer,float angle);
	__declspec(dllexport)    void		                Camera_Pitch(SPCamera* pointer,float angle);
	__declspec(dllexport)    void		                Camera_SetProjectionType(SPCamera* pointer,SPCamera::ProjectionTypes type);
	__declspec(dllexport)    SPCamera::ProjectionTypes  Camera_GetProjectionType(SPCamera* pointer);

	__declspec(dllexport)    void		                EntityPattern_SetName(S33EntityPattern* pointer,const char* value);
	__declspec(dllexport)    const char*                EntityPattern_GetName(S33EntityPattern* pointer);
	__declspec(dllexport)    S33EntityPattern::Types    EntityPattern_GetType(S33EntityPattern* pointer);
	__declspec(dllexport)    void		                EntityPattern_SetType(S33EntityPattern* pointer,S33EntityPattern::Types value);
	__declspec(dllexport)    void		                EntityPattern_SetScript(S33EntityPattern* pointer,const char* script);
	__declspec(dllexport)    const char*                EntityPattern_GetScript(S33EntityPattern* pointer);
	__declspec(dllexport)    void		                EntityPattern_Save(S33EntityPattern* pointer,const char* filename);

	__declspec(dllexport)    S33EntityParameters*       Entity_GetEP(S33Entity* pointer);
	__declspec(dllexport)    void		                Entity_Release(S33Entity* pointer);
	__declspec(dllexport)    void		                Entity_Update(S33Entity* pointer);
	__declspec(dllexport)    void		                Entity_Render(S33Entity* pointer);
	__declspec(dllexport)    S33Entity*	                Entity_Pick(S33Entity* pointer,int x, int y);
	__declspec(dllexport)    S33EntityPattern*          Entity_GetPattern(S33Entity* pointer);
	__declspec(dllexport)    S33Entity::Types           Entity_GetType(S33Entity* pointer);
	
	__declspec(dllexport)    SPVector3*                 Vector3_New();
	__declspec(dllexport)    float		                Vector3_GetX(SPVector3* pointer);
	__declspec(dllexport)    float		                Vector3_GetY(SPVector3* pointer);
	__declspec(dllexport)    float		                Vector3_GetZ(SPVector3* pointer);
	__declspec(dllexport)    void		                Vector3_SetX(SPVector3* pointer,float value);
	__declspec(dllexport)    void		                Vector3_SetY(SPVector3* pointer,float value);
	__declspec(dllexport)    void		                Vector3_SetZ(SPVector3* pointer,float value);

	
	__declspec(dllexport)    S33EntityParameters*       EntityParameters_New();
	__declspec(dllexport)    SPVector3*                 EntityParameters_GetPosition(S33EntityParameters* pointer);
	__declspec(dllexport)    SPVector3*                 EntityParameters_GetRotation(S33EntityParameters* pointer);
	__declspec(dllexport)    SPVector3*                 EntityParameters_GetScale(S33EntityParameters* pointer);
	__declspec(dllexport)    const char*                EntityParameters_GetName(S33EntityParameters* pointer);
	__declspec(dllexport)    void		                EntityParameters_SetName(S33EntityParameters* pointer,const char* value);
	__declspec(dllexport)    int		                EntityParameters_GetVisible(S33EntityParameters* pointer);
	__declspec(dllexport)    void		                EntityParameters_SetVisible(S33EntityParameters* pointer,bool value);
	__declspec(dllexport)    void		                EntityParameters_SetColor(S33EntityParameters* pointer,unsigned char r,unsigned char g,unsigned char b,unsigned char a);
	__declspec(dllexport)    DWORD		                EntityParameters_GetColor(S33EntityParameters* pointer);
	__declspec(dllexport)    void		                EntityParameters_SetTransparency(S33EntityParameters* pointer,unsigned char value);
	__declspec(dllexport)    unsigned char              EntityParameters_GetTransparency(S33EntityParameters* pointer);
	__declspec(dllexport)    unsigned char              EntityParameters_GetBlendingMode(S33EntityParameters* pointer);
	__declspec(dllexport)    void			            EntityParameters_SetBlendingMode(S33EntityParameters* pointer,SPRenderingParameters::BlendingMode value);

	__declspec(dllexport)    S33Entity*		            ComplexEntity_AddChild(S33ComplexEntity* pointer,S33EntityPattern* pattern,S33EntityParameters* ep);
	__declspec(dllexport)    void						ComplexEntity_SortChildsByDepth(S33ComplexEntity* pointer);
	__declspec(dllexport)    void						ComplexEntity_SaveAsComplexEntityPattern(S33ComplexEntity* pointer,const char* filename);
	
	__declspec(dllexport)    SPRect*                    Rect_New();
	__declspec(dllexport)    int                        Rect_GetTop(SPRect* pointer);
	__declspec(dllexport)    int                        Rect_GetBottom(SPRect* pointer);
	__declspec(dllexport)    int                        Rect_GetLeft(SPRect* pointer);
	__declspec(dllexport)    int                        Rect_GetRight(SPRect* pointer);
	__declspec(dllexport)    void                       Rect_SetTop(SPRect* pointer,int value);
	__declspec(dllexport)    void                       Rect_SetBottom(SPRect* pointer,int value);
	__declspec(dllexport)    void                       Rect_SetLeft(SPRect* pointer,int value);
	__declspec(dllexport)    void                       Rect_SetRight(SPRect* pointer,int value);

	__declspec(dllexport)    S33ScenePattern*		    Library_GetScenePattern(const char* name);
	__declspec(dllexport)    S33SpritePattern*          Library_GetSpritePattern(const char* name);
	__declspec(dllexport)    S33ComplexEntityPattern*   Library_GetComplexEntityPattern(const char* name);

	//_____________________________________________________________________________________________
	//---------------------------------------------------------------------------------------------
	//Box2D ...
	__declspec(dllexport)    b2Vec2*                    b2Vec2_New();
	__declspec(dllexport)    float                      b2Vec2_GetX(b2Vec2* pointer);
	__declspec(dllexport)    float                      b2Vec2_GetY(b2Vec2* pointer);
	__declspec(dllexport)    void                       b2Vec2_SetX(b2Vec2* pointer,float value);
	__declspec(dllexport)    void                       b2Vec2_SetY(b2Vec2* pointer,float value);

	__declspec(dllexport)    b2Shape::Type              b2Shape_GetType(b2Shape* pointer);
	__declspec(dllexport)    void		                b2Shape_SetType(b2Shape* pointer,b2Shape::Type value);
	__declspec(dllexport)    float			            b2Shape_GetRadius(b2Shape* pointer);
	__declspec(dllexport)    void 			            b2Shape_SetRadius(b2Shape* pointer,float value);

	__declspec(dllexport)    b2CircleShape*             b2CircleShape_New();
	__declspec(dllexport)    b2Vec2*			        b2CircleShape_GetPosition(b2CircleShape* pointer);

	__declspec(dllexport)    b2PolygonShape*            b2PolygonShape_New();
	__declspec(dllexport)    b2Vec2*		            b2PolygonShape_GetCentroid(b2PolygonShape* pointer);
	__declspec(dllexport)    b2Vec2*		            b2PolygonShape_GetVertex(b2PolygonShape* pointer,int index);
	__declspec(dllexport)    int			            b2PolygonShape_GetVertexesCount(b2PolygonShape* pointer);
	__declspec(dllexport)    void 			            b2PolygonShape_SetVertexesCount(b2PolygonShape* pointer,int value);
	__declspec(dllexport)    void 			            b2PolygonShape_SetAsBox(b2PolygonShape* pointer,float width,float height);

	__declspec(dllexport)    b2FixtureDef*	            b2FixtureDef_New();
	__declspec(dllexport)    b2Shape*		            b2FixtureDef_GetShape(b2FixtureDef* pointer);
	__declspec(dllexport)    float  		            b2FixtureDef_GetFriction(b2FixtureDef* pointer);
	__declspec(dllexport)    float  		            b2FixtureDef_GetRistitution(b2FixtureDef* pointer);
	__declspec(dllexport)    float  		            b2FixtureDef_GetDensity(b2FixtureDef* pointer);
	__declspec(dllexport)    int    		            b2FixtureDef_GetIsSensor(b2FixtureDef* pointer);
	__declspec(dllexport)    void			            b2FixtureDef_SetShape(b2FixtureDef* pointer,b2Shape* value);
	__declspec(dllexport)    void  			            b2FixtureDef_SetFriction(b2FixtureDef* pointer,float value);
	__declspec(dllexport)    void  			            b2FixtureDef_SetRistitution(b2FixtureDef* pointer,float value);
	__declspec(dllexport)    void	 		            b2FixtureDef_SetDensity(b2FixtureDef* pointer,float value);
	__declspec(dllexport)    void   		            b2FixtureDef_SetIsSensor(b2FixtureDef* pointer,bool value);
	
	__declspec(dllexport)    b2Fixture*	                b2Fixture_GetNext(b2Fixture* pointer);
	__declspec(dllexport)    b2Shape*		            b2Fixture_GetShape(b2Fixture* pointer);
	__declspec(dllexport)    float  		            b2Fixture_GetFriction(b2Fixture* pointer);
	__declspec(dllexport)    float  		            b2Fixture_GetRistitution(b2Fixture* pointer);
	__declspec(dllexport)    float  		            b2Fixture_GetDensity(b2Fixture* pointer);
	__declspec(dllexport)    int    		            b2Fixture_GetIsSensor(b2Fixture* pointer);
	__declspec(dllexport)    void  			            b2Fixture_SetFriction(b2Fixture* pointer,float value);
	__declspec(dllexport)    void  			            b2Fixture_SetRistitution(b2Fixture* pointer,float value);
	__declspec(dllexport)    void	 		            b2Fixture_SetDensity(b2Fixture* pointer,float value);
	__declspec(dllexport)    void   		            b2Fixture_SetIsSensor(b2Fixture* pointer,bool value);
	
	__declspec(dllexport)    b2BodyDef*			        b2BodyDef_New();
	__declspec(dllexport)    b2Vec2*			        b2BodyDef_GetPosition(b2BodyDef* pointer);
	__declspec(dllexport)    b2Vec2*			        b2BodyDef_GetLinearVelocity(b2BodyDef* pointer);
	__declspec(dllexport)    b2BodyType			        b2BodyDef_GetType(b2BodyDef* pointer);
	__declspec(dllexport)    float				        b2BodyDef_GetAngle(b2BodyDef* pointer);
	__declspec(dllexport)    float				        b2BodyDef_GetAngularVelocity(b2BodyDef* pointer);
	__declspec(dllexport)    float				        b2BodyDef_GetLinearDamping(b2BodyDef* pointer);
	__declspec(dllexport)    float				        b2BodyDef_GetAngularDamping(b2BodyDef* pointer);
	__declspec(dllexport)    int				        b2BodyDef_GetAllowSleep(b2BodyDef* pointer);
	__declspec(dllexport)    int				        b2BodyDef_GetAwake(b2BodyDef* pointer);
	__declspec(dllexport)    int				        b2BodyDef_GetFixedRotation(b2BodyDef* pointer);
	__declspec(dllexport)    int				        b2BodyDef_GetBullet(b2BodyDef* pointer);
	__declspec(dllexport)    int				        b2BodyDef_GetActive(b2BodyDef* pointer);
	__declspec(dllexport)    float				        b2BodyDef_GetInertiaScale(b2BodyDef* pointer);
	__declspec(dllexport)    void				        b2BodyDef_SetType(b2BodyDef* pointer,b2BodyType value);
	__declspec(dllexport)    void				        b2BodyDef_SetAngle(b2BodyDef* pointer,float value);
	__declspec(dllexport)    void				        b2BodyDef_SetAngularVelocity(b2BodyDef* pointer,float value);
	__declspec(dllexport)    void				        b2BodyDef_SetLinearDamping(b2BodyDef* pointer,float value);
	__declspec(dllexport)    void				        b2BodyDef_SetAngularDamping(b2BodyDef* pointer,float value);
	__declspec(dllexport)    void				        b2BodyDef_SetAllowSleep(b2BodyDef* pointer,bool value);
	__declspec(dllexport)    void				        b2BodyDef_SetAwake(b2BodyDef* pointer,bool value);
	__declspec(dllexport)    void				        b2BodyDef_SetFixedRotation(b2BodyDef* pointer,bool value);
	__declspec(dllexport)    void				        b2BodyDef_SetBullet(b2BodyDef* pointer,bool value);
	__declspec(dllexport)    void				        b2BodyDef_SetActive(b2BodyDef* pointer,bool value);
	__declspec(dllexport)    void				        b2BodyDef_SetInertiaScale(b2BodyDef* pointer,float value);
	
	__declspec(dllexport)    b2Vec2*			        b2Body_GetPosition(b2Body* pointer);
	__declspec(dllexport)    b2BodyType			        b2Body_GetType(b2Body* pointer);
	__declspec(dllexport)    float				        b2Body_GetAngle(b2Body* pointer);
	__declspec(dllexport)    float				        b2Body_GetAngularVelocity(b2Body* pointer);
	__declspec(dllexport)    float				        b2Body_GetLinearDamping(b2Body* pointer);
	__declspec(dllexport)    float				        b2Body_GetAngularDamping(b2Body* pointer);
	__declspec(dllexport)    int				        b2Body_GetAllowSleep(b2Body* pointer);
	__declspec(dllexport)    int				        b2Body_GetAwake(b2Body* pointer);
	__declspec(dllexport)    int				        b2Body_GetFixedRotation(b2Body* pointer);
	__declspec(dllexport)    int				        b2Body_GetBullet(b2Body* pointer);
	__declspec(dllexport)    int				        b2Body_GetActive(b2Body* pointer);
	__declspec(dllexport)    void				        b2Body_SetType(b2Body* pointer,b2BodyType value);
	__declspec(dllexport)    void				        b2Body_SetAngularVelocity(b2Body* pointer,float value);
	__declspec(dllexport)    void				        b2Body_SetLinearDamping(b2Body* pointer,float value);
	__declspec(dllexport)    void				        b2Body_SetAngularDamping(b2Body* pointer,float value);
	__declspec(dllexport)    void				        b2Body_SetAllowSleep(b2Body* pointer,bool value);
	__declspec(dllexport)    void				        b2Body_SetAwake(b2Body* pointer,bool value);
	__declspec(dllexport)    void				        b2Body_SetFixedRotation(b2Body* pointer,bool value);
	__declspec(dllexport)    void				        b2Body_SetBullet(b2Body* pointer,bool value);
	__declspec(dllexport)    void				        b2Body_SetActive(b2Body* pointer,bool value);
	__declspec(dllexport)    void				        b2Body_CreateFixture(b2Body* pointer,b2FixtureDef* value);
	__declspec(dllexport)    b2Fixture*			        b2Body_GetFixtureList(b2Body* pointer);
}