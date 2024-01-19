import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { HotelbookingComponent } from '../hotelbooking/hotelbooking.component';
import { FlightBookingComponent } from '../flight-booking/flight-booking.component';

@Component({
  selector: 'app-booking',
  standalone: true,
  imports: [RouterLink,RouterOutlet,HotelbookingComponent,FlightBookingComponent],
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.css'
})
export class BookingComponent {
show:boolean=true;

showMessage(){
  this.show = false;
}

}


