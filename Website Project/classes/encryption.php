<?php
class Encryption
{
    public function Encrypt($plaintext){
        $password = 'ShpG`6G*(f2';
        $method = 'aes-256-cbc';
        
        // Must be exact 32 chars (256 bit)
        $password = substr(hash('sha256', $password, true), 0, 32);
        
        
        // IV must be exact 16 chars (128 bit)
        $iv = chr(0x48). chr(0x75). chr(0x69). chr(0x6d). chr(0x21). chr(0x5a). chr(0x55). chr(0x62). chr(0x68). chr(0x72). chr(0x60). chr(0x64). chr(0x78). chr(0x42). chr(0x35). chr(0x16);
        // av3DYGLkwBsErphcyYp+imUW4QKs19hUnFyyYcXwURU=
        $encrypted = base64_encode(openssl_encrypt($plaintext, $method, $password, OPENSSL_RAW_DATA, $iv));
        
        // My secret message 1234
        $decrypted = openssl_decrypt(base64_decode($encrypted), $method, $password, OPENSSL_RAW_DATA, $iv);
        
        return $encrypted;
        
        exit; 
    }
    public function Decrypt($plaintext){
        $password = 'ShpG`6G*(f2';
        $method = 'aes-256-cbc';
        
        // Must be exact 32 chars (256 bit)
        $password = substr(hash('sha256', $password, true), 0, 32);
        
        // IV must be exact 16 chars (128 bit)
        $iv = chr(0x48). chr(0x75). chr(0x69). chr(0x6d). chr(0x21). chr(0x5a). chr(0x55). chr(0x62). chr(0x68). chr(0x72). chr(0x60). chr(0x64). chr(0x78). chr(0x42). chr(0x35). chr(0x16);
        // av3DYGLkwBsErphcyYp+imUW4QKs19hUnFyyYcXwURU=
        $encrypted = base64_encode(openssl_encrypt($plaintext, $method, $password, OPENSSL_RAW_DATA, $iv));
        
        // My secret message 1234
        $decrypted = openssl_decrypt(base64_decode($encrypted), $method, $password, OPENSSL_RAW_DATA, $iv);
        
        return $decrypted;
        
        exit; 
    }

}
?>