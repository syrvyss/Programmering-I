use std::io;

fn main() {
    println!("What is your score?: ");
    let mut score = String::new();
    io::stdin().read_line(&mut score).unwrap();

    let score = score.trim().parse::<i32>().unwrap();

    println!("Your grade is {}!", grade(score));
}

fn grade(score: i32) -> String {
    match score {
        92..=100 => "12",
        75..=91 => "10",
        67..=74 => "7",
        58..=66 => "4",
        50..=57 => "02",
        20..=49 => "00",
        _ => "-3"
    }.to_string()
}