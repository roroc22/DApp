import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//在組件中實現一個生命週期，要做到這點我們要實現一個接口
export class AppComponent implements OnInit{
  title = 'Dating App';
  users: any;

  constructor(private http:HttpClient){}

  ngOnInit():void{
    this.http.get("https://localhost:5001/api/users").subscribe({
      next: response => this.users= response,
      error: error => console.log(error),
      complete:() => console.log("Request has completed")
     
  })}
}

