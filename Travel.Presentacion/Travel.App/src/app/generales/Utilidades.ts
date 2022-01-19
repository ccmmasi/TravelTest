import { Injectable } from '@angular/core';
import * as CryptoJS from '../../../node_modules/crypto-js'; 
import { environment } from 'environments/environment';

@Injectable()
export class Utilidades {

    private Encrypted;
    private Dencrypted;
    private key = CryptoJS.enc.Utf8.parse(Base64.decode(Base64.decode(process.env.YEK)));
    private iv = CryptoJS.enc.Utf8.parse(Base64.decode(Base64.decode(process.env.VI)));
    private env = environment;

    constructor(
      private userEnteredService?: UserEnteredService,
      private generalService?: GeneralService,
      private router?: Router,
      private _cookieService?: CookieService
    ) {

    }

    public $Encrypted(request): string {
      try {
        const encrypted = CryptoJS.AES.encrypt(CryptoJS.enc.Utf8.parse(request), this.key, {
          keySize: 256,
          iv: this.iv,
          mode: CryptoJS.mode.CBC,
          padding: CryptoJS.pad.Pkcs7
        });

        return encrypted;
      } catch (error) {
        return error;
      }
    }

    public $Decrypted(dataFinal): string {
      const decrypted = CryptoJS.AES.decrypt(dataFinal, this.key, {
        keySize: 256,
        iv: this.iv,
        mode: CryptoJS.mode.CBC,
        padding: CryptoJS.pad.Pkcs7
      });

      return Base64.decode(decrypted.toString(CryptoJS.enc.Utf8));
    }
}
