import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit{
  title = 'The Dating App';
  users : any;
  
  constructor(private http: HttpClient){}

  ngOnInit(){
   this.getUsers()
  }

  displayUsers(users){ 
    let names = []
    for(let i in users){
      names.push(users[i].userName)
    }

    return names
  }

  getUsers(){
    this.http.get("https://localhost:5001/api/surfusers").subscribe({
      next: response => this.users = response,
      error: er => console.log(er)
    })
  }
}

  



