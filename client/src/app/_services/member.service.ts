import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class MemberService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getMembers() {
    return this.http.get<User[]>(this.baseUrl + 'users');
  }

  getMember(email: string) {
    return this.http.get<User[]>(this.baseUrl + 'users/' + email);
  }
}
