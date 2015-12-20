Shader ".ShaderTest/Diffuse"
{

	//note that the normal positiion semantic needs to be re
	Properties
	{
		_Color("Main Color", Color) = (1,1,1,1)
		_MainTex("Main Texture", 2D) = "white" {}
		_SpecColor ("Specular Color", Color) = (1,1,1,1)
		_SpecShininess ("Specular Shiniess", Range(1.0, 100.0)) = 2.0
	}

	SubShader
	{
		Pass {
		 Tags {"LightMode" = "ForwardBase" }
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float2 texcoord : TEXCOORD0;

			};

			struct v2f 
			{
				float4 pos : SV_POSITION;
				float3 normal : NORMAL;
				float2 texcoord : TEXCOORD0;
			};
			float4 _LightColor0;
			fixed4 _Color;
			sampler2D _MainTex;

			v2f vert (appdata IN)
			{
				v2f OUT;
				OUT.pos = mul(UNITY_MATRIX_MVP, IN.vertex);
				// normals come in object space just like vertices
				OUT.normal = mul(float4(IN.normal, 0.0), _Object2World).xyz; // this changes them to world space so that it makes them shadable
				//.xyz at the end is called swizzling ^_^ ^^^^. the multiplying returns a float 4 but we just want the xyz components so we swizzle it dawwwwgggg
				OUT.texcoord = IN.texcoord;
				return OUT;
			}

			fixed4 frag(v2f IN) : COLOR 
			{
				
				fixed4 texColor = tex2D(_MainTex, IN.texcoord);
				//return texColor;
			float3 normalDirection = normalize(IN.normal);
			//next line hard codes light we use. first light in the scene and must be dirrectional
			float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
			float3 diffuse = _LightColor0.rgb * max(0.0, dot(normalDirection, lightDirection));

			return _Color * texColor * float4(diffuse, 1);

				//return _Color;
			}
			ENDCG

	
		}


	}


}