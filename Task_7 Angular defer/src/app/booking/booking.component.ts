import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { HotelbookingComponent } from '../hotelbooking/hotelbooking.component';
import { FlightBookingComponent } from '../flight-booking/flight-booking.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-booking',
  standalone: true,
  imports: [RouterLink,RouterOutlet,HotelbookingComponent,FlightBookingComponent,CommonModule],
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.css'
})
export class BookingComponent {
show:boolean=false;

// showMessage(){
//   this.show = true;
// }

}


