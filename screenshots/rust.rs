
#[derive(Debug)]
struct Fox {
    is_quick: bool,
    name: String,
    jump_speed: f32,
    humiliated_dogs: Vec::<Dog>,
}

impl Fox {
    fn new(name: String) -> Fox {
        Fox {
            is_quick: true,
            name: name,
            jump_speed: 0.0;
            humiliated_dogs: Vec::new()
        }
    }
}

