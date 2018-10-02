import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient } from "@angular/common/http";

import { environment } from "../../../environments/environment";

const API_URL = environment.apiUrl;

@Injectable()
export class UserService {
  constructor(private http: HttpClient) { }

  userAuthentication(userName, password) {
    var data = {UserName:'9672314115',Password:'123456'};
    var requestHeader = new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'application/json'
    });
    return this.http.post(API_URL + "/account", data, { headers: requestHeader });
  }
}
