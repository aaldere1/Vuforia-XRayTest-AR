Shader "Custom/XRay"
{
    Subshader
    {
        //2000 - 2999 -> Opaque Objects
        //3000 - 3999 -> Transparent Objects
        // render after every transparent object and opaque object
        Tags { "Queue" = "Transparent+1" } // 3000
        
        Pass { Blend Zero One } // make it invisble
        
    }
}
